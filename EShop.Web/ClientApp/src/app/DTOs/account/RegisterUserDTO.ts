export class RegisterUserDTO {
  constructor(
    public email: string,
    public firstName: string,
    public lastName: string,
    public password: string,
    public passwordConfirm: string,
    public address: string
  ) {
  }
}
