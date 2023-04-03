using EShop.Application.DTOs.Account;
using EShop.Application.Interfaces;
using EShop.Application.Security;
using EShop.Domain.Entities.Account;
using EShop.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EShop.Application.Services
{
    public class UserService : IUserService
    {
        private IGenericRepository<User> _userRepository;
        private IPasswordHelper _passwordHelper;

        #region Constructor

        public UserService(IGenericRepository<User> userRepository, IPasswordHelper passwordHelper)
        {
            _userRepository = userRepository;
            _passwordHelper = passwordHelper;
        }

        #endregion

        #region UserSection

        public async Task<List<User>> GetAllUsers()
        {
            return await _userRepository.GetEntitiesQuery().ToListAsync();
        }

        #endregion

        public void Dispose()
        {
            _userRepository.Dispose();
        }

        public async Task<RegisterUserResult> RegisterUser(RegisterUserDTO register)
        {
            if (IsEmailExists(register.Email))
                return RegisterUserResult.EmailExists;

            var user = new User
            {
                Email = register.Email.SanitizeText(),
                FirstName = register.FirstName.SanitizeText(),
                LastName = register.LastName.SanitizeText(),
                Address = register.Address.SanitizeText(),
                EmailActivationCode = Guid.NewGuid().ToString(),
                Password = _passwordHelper.EncodePasswordMd5(register.Password)
            };

            await _userRepository.AddEntity(user);

            await _userRepository.SaveChanges();

            return RegisterUserResult.Success;
        }

        public async Task<LoginUserResult> LoginUser(LoginUserDTO login)
        {
            var password = _passwordHelper.EncodePasswordMd5(login.Password);

            var user = await _userRepository.GetEntitiesQuery()
                .FirstOrDefaultAsync(u => u.Email == login.Email.ToLower().Trim() && u.Password == password);

            if (user == null)
                return LoginUserResult.IncorrectUsernameOrPassword;

            if(!user.IsActivated)
                return LoginUserResult.NotActivated;

            return LoginUserResult.Success;
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _userRepository.GetEntitiesQuery().SingleOrDefaultAsync(u => u.Email == email.ToLower().Trim());
        }

        public bool IsEmailExists(string email)
        {
            return _userRepository.GetEntitiesQuery().Where(e => e.Equals(email.ToLower().Trim())).Any();
        }
    }
}
