using EShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Infrastructure.Data.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {

            builder.HasOne(b => b.Publisher)
                   .WithMany(p => p.Books)
                   .HasForeignKey(b => b.PublisherId);

            #region Seed Data Book

            builder.HasData(
                new Book
                {
                    Id = 1,
                    Title = "عاشقانه ملت عشق",
                    Shabak = "9789643119195",
                    Author = "الیف شافاک",
                    Description = "چهل قاعده عشق که به نام ملت عشق نیز شناخته می‌شود، توسط نویسنده فرانسوی متولد ترکیه «الیف شافاک» نوشته شده است. این رمان که پرفروش‌ترین کتاب تاریخ ترکیه به حساب می‌آید، اثری برگرفته از ارتباط عرفانی بین شمس تبریزی و مولانا است که به صورت دو داستان موازی و در هم تنیده روایت می‌شود. بطن اصلی کتاب حول موضوع عشق و نقش آن در دنیای مدرن امروز نسبت به گذشته می‌نگرد و چنان آن را از غرب به شرق گسترش می‌دهد که به زندگی رنگ و بویی عرفانی و زاییده شده از عشق می‌دهد. اینکه چگونه قطعه سنگی کوچک، برکه‌ای راکد و خاموش را به تلاطم و جنبش وا می‌دارد.",
                    Release_Date = new DateTime(2015, 04, 04),
                    Price = 95000,
                    PublisherId = 1,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 2,
                    Title = "مردی به نام اوه",
                    Shabak = "9786007141779",
                    Author = "فردریک بکمن",
                    Description = "رمان مردی به نام اوه عنوان اولین کتاب فردریک بک من است که به سی زبان دنیا ترجمه شده و به عنوان پرفروش‌ترین کتاب سال سوئد معروف شده است و در ایران نیز با ترجمه الناز فرحناکیان توسط نشر نون به چاپ رسیده است. در ادامه با ما همراه باشید تا با معرفی این کتاب جذاب که از پرفروش‌ترین‌های سایت آمازون در سال 2016 نیز به حساب می آید شما را با دنیای نویسندگی فردریک بک من آشنا کنیم.",
                    Release_Date = new DateTime(2016, 01, 05),
                    Price = 95000,
                    PublisherId = 2,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 3,
                    Title = "وقتی نیچه گریست",
                    Shabak = "9786001192029",
                    Author = "اروین یالوم",
                    Description = "قبل از خواندن کتاب وقتی نیچه گریست نوشتهُ اروین یالوم با ترجمه سپیده حبیب چه روشی دارید؟ آیا تحقیقی در مورد داستان آن انجام داده‌اید؟، یا شما فقط بدون هیچ گونه اطلاعات قبلی خواندن کتاب را شروع می‌کنید؟ من شخصاً گزینه دوم را ترجیح می‌دهم. بدون اینکه ایده‌ای از آنچه در مورد این رمان بزرگ داشته باشم، خواندن را شروع کردم. در میانه‌های کتاب با خود گفتم: «پرسش‌ها چه هستند؟ و آیا پاسخ‌هایی به فراخور آن وجود دارد؟ علائم اصلی عجز و ناتوانی فردریش نیچه چیست‌اند؟ و یوزف برویر چگونه می‌تواند به روان نیچه وارد شود؟»",
                    Release_Date = new DateTime(2020, 12, 21),
                    Price = 65000,
                    PublisherId = 3,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 4,
                    Title = "جزء از کل",
                    Shabak = "9786002295002",
                    Author = "استیو تولتز",
                    Description = "روزی نویسندگان و مورخان در آینده به این دوره از تاریخ نگاه می‌کنند و از رمانی صحبت می‌کنند که همه حتی خردسالان و سالمندان را منقلب کرده است. این رمان بی‌شک «جز از کل» نوشته‌ی «استیو تولز» رمان‌نویس استرالیایی خواهد بود که از اعماق وجود انسان‌ها سخن می‌گوید. «جز از کل» درامی خانوادگی است که ترس، انتظار و زندگی را به شکل متفاوتی معنا می‌کند و به تصویر می‌کشد و هر پاراگراف آن، خود داستانی تأمل‌برانگیز است.",
                    Release_Date = new DateTime(2016, 01, 05),
                    Price = 160000,
                    PublisherId = 4,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 5,
                    Title = "مغازه خودکشی",
                    Shabak = "9786002298812",
                    Author = "ژان تولی",
                    Description = "بعضی رمان‌ها خلاف جریان آب شنا می‌کنند و این داستان را بسیار خواندنی‌تر و جذاب‌تر می‌کند. کمدی سیاه یک ژانر معروف در ادبیات است که با بیان واقعیات جامعه به زبان طنز سعی دارد هم از اتفاقات جامعه بگوید و هم با روایت کمدی لبخند بر روی لب خواننده بیاورد. یکی از معروف‌ترین کتاب‌های کمدی سیاه مغازه‌ی خودکشی به قلم ژان تولی است. شما با خواندن این کتاب به شهری در آینده‌ی دور می‌روید. جایی بی‌نام و نشان که ممکن است با آن احساس نزدیکی کنید. در سال ۲۰۱۲ نیز از این کتاب یک انیمیشن فرانسوی ساخته شد.",
                    Release_Date = new DateTime(2018, 01, 05),
                    Price = 38000,
                    PublisherId = 4,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 6,
                    Title = "مزرعۀ حیوانات",
                    Shabak = "964604799",
                    Author = "جورج اورول‌",
                    Description = "کتاب قلعه حیوانات با عنوان اصلی (Animal Farm) نخستین بار در سال 1945 منتشر شد. جورج اورول این کتاب را در طول جنگ جهانی دوم نوشت و در آن از استبداد طبقه‌ی حاکم شوروی انتقاد کرد. پرچمی که اورول در داستان برای مزرعه‌ی حیوانات ترسیم می‌کند شبیه به پرچم شوروی است. این کتاب درواقع نقدی به نظام سرمایه‌داری است.",
                    Release_Date = new DateTime(2021, 03, 01),
                    Price = 5000,
                    PublisherId = 15,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 7,
                    Title = "زمان فراموشی",
                    Shabak = "9786004613644",
                    Author = "شارون گاسکین",
                    Description = "«آقای دکتر متوجه چیزهایی که گفتم می‌‌شین؟» تنفس! کلمه‌ای که هم دم و هم بازدم دارد. اگر انسان چنین کلمه‌ای را از دست بدهد همه‌چیز را از دست داده است. «آقای دکتر...» «متوجه می‌شم؟ معلومه! اون‌قدرها هم پرت نشده‌م؛ هنوز نه. به‌نظر می‌آد هنوز می‌تونم ساختارهای سادۀ جملات رو رمزگشایی کنم.» حس می‌کرد صدایش در حال خارج‌شدن از کنترل است و به‌سختی توانست مهارش کند. «حالتون خوبه؟» نبض خودش را حس می‌کرد. به‌نظر عادی می‌آمد اما کاملاً مطمئن نبود. «می‌شه گوشی طبی‌تون رو قرض بگیرم؟»",
                    Release_Date = new DateTime(2020, 03, 05),
                    Price = 55000,
                    PublisherId = 16,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 8,
                    Title = "از سرزمین‌های انگور",
                    Shabak = "9786004624763",
                    Author = "پم مونیوس رایان",
                    Description = "«این دره نفس می‌کشه و زنده‌ست!» پاپا دستش را به سمت کوه‌هایی بلند کرد که از دور مراقبشان بودند و گفت: «انگورهایی رو بهمون می‌ده که ازمون استقبال می‌کنن.» پدر، به‌آرامی، پیچکی وحشی را نوازش کرد که از روی داربست به پایین خم شده بود و انگار منتظر بود با او دست بدهد. مشتی خاک برداشت و کف دستش وارسی کرد و گفت: «می‌دونستی که وقتی روی زمین دراز بکشی، می‌تونی نفس کشیدن و تپیدن قلبش رو حس کنی؟»",
                    Release_Date = new DateTime(2019, 03, 05),
                    Price = 49000,
                    PublisherId = 14,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 9,
                    Title = "گوشه‌ی دنج کلاس",
                    Shabak = "9786004625104",
                    Author = "دبورا ھاپکینسن",
                    Description = "معلم عزیزم، هر زمان می‌خواستم چیزی به تو بگویم، گوشه‌ی لباست را می‌کشیدم و در گوشت زمزمه می‌کردم؛ این بار می‌خواهم نامه‌ای برایت بنویسم...! دخترکی که حالا بزرگ شده برای معلمش نامه‌ای می‌نویسد و خاطرات دوران مدرسه‌ و مهربانی‌های معلمش را تعریف می‌کند. او به یاد معلمش افتاده و تصمیم گرفته برای او نامه‌ای بنویسد. حالا دخترک خودش هم یک معلم است. این کتاب، داستانی احساسی و روایتی زیبا و خواندنی از تلاش‌ها و مهربانی‌های معلمان است. همچنین بر این نکته تمرکز می‌کند که باید قدردان زحمات معلم‌ها باشیم.",
                    Release_Date = new DateTime(2019, 03, 05),
                    Price = 49000,
                    PublisherId = 14,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 10,
                    Title = "سه قطره خون",
                    Shabak = "9786004516464",
                    Author = "صادق هدایت",
                    Description = "دیروز بود که اتاقم را جدا کردند، آیا همان‌طوری که ناظم وعده داد من حالا به‌کلی معالجه شده‌ام و هفته‌ی دیگر آزاد خواهم شد؟ آیا ناخوش بوده‌ام؟ یکسال است، در تمام این مدت هرچه التماس می‌کردم کاغذ و قلم می‌خواستم بهم نمی‌دادند. همیشه پیش خودم گمان می‌کردم هر ساعتی که قلم و کاغذ بدستم بیفتد چقدر چیزها که نخواهم نوشت… ولی دیروز بدون اینکه خواسته باشم کاغذ و قلم را برایم آوردند. چیزی که آنقدر آرزو می‌کردم، چیزی که انتظارش را داشتم ...! اما چه فایده ... از دیروز تا حالا هرچه فکر می‌کنم چیزی ندارم که بنویسم. مثل این است که کسی دست مرا می‌گیرد یا بازویم بی‌حس می‌شود. حالا که دقت می‌کنم مابین خط‌های درهم و برهمی که روی کاغذ کشیده‌ام تنها چیزی که خوانده می‌شود این است: «سه قطره خون»",
                    Release_Date = new DateTime(2020, 03, 04),
                    Price = 8500,
                    PublisherId = 17,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 11,
                    Title = "یک خانوادۀ تقریباً معمولی",
                    Shabak = "9786004613637",
                    Author = "ام. تی. ادواردسن",
                    Description = "همسرم در همین اتاق رسیدگی حضور دارد. قبل از اینکه وارد شویم و از بخش حراست عبور کنیم، روی پله‌های بیرون دادگاه همدیگر را در آغوش کشیدیم. سپس با دستان لرزانش دستانم را فشرد و گفت کاری از دست ما ساخته نیست و رأی نهایی را شخص دیگری صادر می‌کند. هر دوی ما می‌دانیم که این اصلاً عادلانه نیست. با شنیدن صدای بلندگو ته دلم خالی می‌شود. مرا صدا می‌کنند. باید بروم داخل. به‌سختی از جایم بلند می‌شوم. مأمور در را برایم باز می‌کند. سرش را به نشانۀ تأیید تکان می‌دهد. چهرۀ بی‌تفاوتی دارد، هرچند اینجا جای فکر کردن به این مسائل نیست. اتاق شمارۀ ۲ خیلی بزرگ‌تر از انتظارم است. همسرم با ظاهری کاملاً خسته و گونه‌هایی خیس بین حضار دیده می‌",
                    Release_Date = new DateTime(2020, 03, 04),
                    Price = 70000,
                    PublisherId = 16,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 12,
                    Title = "شب ترمیدور",
                    Shabak = "9786001760112",
                    Author = "ژاک شابان",
                    Description = "Description",
                    Release_Date = new DateTime(2015, 03, 05),
                    Price = 12000,
                    PublisherId = 18,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 13,
                    Title = "اسکندر",
                    Shabak = "9786003672765",
                    Author = "الیف شافاک",
                    Description = "Description",
                    Release_Date = new DateTime(2017, 03, 04),
                    Price = 69000,
                    PublisherId = 19,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 14,
                    Title = "رویای عمو جان",
                    Shabak = "9789642575398",
                    Author = "فیودور داستایوفسکی",
                    Description = "Description",
                    Release_Date = new DateTime(2022, 03, 07),
                    Price = 16000,
                    PublisherId = 18,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 15,
                    Title = "بعضی از رازها را نباید نگه‌داشت",
                    Shabak = "9786004623377",
                    Author = "جینین ساندرز ، کریگ اسمیت",
                    Description = "Description",
                    Release_Date = new DateTime(2019, 03, 05),
                    Price = 49000,
                    PublisherId = 14,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 16,
                    Title = "باشگاه پنج صبحی‌‌ها",
                    Shabak = "9786226242226",
                    Author = "رابین شارما",
                    Description = "Description",
                    Release_Date = new DateTime(2021, 03, 05),
                    Price = 158000,
                    PublisherId = 20,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 17,
                    Title = "جهان در پوست گردو",
                    Shabak = "9786009896196",
                    Author = "استیون هاوکینگ",
                    Description = "Description",
                    Release_Date = new DateTime(2022, 03, 06),
                    Price = 8000,
                    PublisherId = 21,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 18,
                    Title = "آدم های سمی",
                    Shabak = "9786009896356",
                    Author = "ليليان گلاس",
                    Description = "Description",
                    Release_Date = new DateTime(2022, 03, 06),
                    Price = 8000,
                    PublisherId = 21,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 19,
                    Title = "اثر مرکب",
                    Shabak = "9786009896141",
                    Author = "دارن هاردی",
                    Description = "Description",
                    Release_Date = new DateTime(2020, 03, 05),
                    Price = 8000,
                    PublisherId = 21,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 20,
                    Title = "بعد از طلاق",
                    Shabak = "9789643288464",
                    Author = "شلی استايل",
                    Description = "Description",
                    Release_Date = new DateTime(2016, 03, 05),
                    Price = 15000,
                    PublisherId = 22,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 21,
                    Title = "عشق هرگز کافی نیست",
                    Shabak = "9789647390569",
                    Author = "آرون تی‌بک",
                    Description = "Description",
                    Release_Date = new DateTime(2018, 03, 06),
                    Price = 35000,
                    PublisherId = 23,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 22,
                    Title = "شاه کلید",
                    Shabak = "9786001180248",
                    Author = "چارلز هانل",
                    Description = "Description",
                    Release_Date = new DateTime(2011, 03, 06),
                    Price = 25000,
                    PublisherId = 23,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 23,
                    Title = "هزار و یک‌دلیل برای شادبودن",
                    Shabak = "9786226683661",
                    Author = "استیون میچل ، بایرون کیتی",
                    Description = "Description",
                    Release_Date = new DateTime(2021, 03, 05),
                    Price = 95000,
                    PublisherId = 24,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 24,
                    Title = "مدیریت هیجان",
                    Shabak = "9789643729691",
                    Author = "نسرین دانائی",
                    Description = "Description",
                    Release_Date = new DateTime(2020, 03, 04),
                    Price = 25000,
                    PublisherId = 13,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 25,
                    Title = "صورتت را بشور دختر",
                    Shabak = "9786226242233",
                    Author = "ریچل هالیس",
                    Description = "Description",
                    Release_Date = new DateTime(2020, 12, 26),
                    Price = 64000,
                    PublisherId = 20,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 26,
                    Title = "فلسفۀ زندگی موفق",
                    Shabak = "9786001182136",
                    Author = "جیم ران",
                    Description = "Description",
                    Release_Date = new DateTime(2018, 03, 02),
                    Price = 20000,
                    PublisherId = 23,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 27,
                    Title = "قهرمان",
                    Shabak = "9786001181528",
                    Author = "روندا برن",
                    Description = "Description",
                    Release_Date = new DateTime(2015, 03, 02),
                    Price = 45000,
                    PublisherId = 23,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 28,
                    Title = "عاشق همیشه تنهاست",
                    Shabak = "964372056x",
                    Author = "سهراب سپهری",
                    Description = "Description",
                    Release_Date = new DateTime(2004, 02, 05),
                    Price = 10000,
                    PublisherId = 13,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 29,
                    Title = "این بانگ دلاویز",
                    Shabak = "9789647230018",
                    Author = "علی باباچاهی",
                    Description = "Description",
                    Release_Date = new DateTime(2020, 02, 06),
                    Price = 68000,
                    PublisherId = 10,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 30,
                    Title = "سفرنامۀ باد",
                    Shabak = "9786004610650",
                    Author = "سیّد رضا محمدی",
                    Description = "Description",
                    Release_Date = new DateTime(2018, 02, 06),
                    Price = 9000,
                    PublisherId = 16,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 31,
                    Title = "خواب‌های مرگ‌آلود",
                    Shabak = "9786004514552",
                    Author = "مصطفی سپهری‌نیا",
                    Description = "Description",
                    Release_Date = new DateTime(2020, 02, 08),
                    Price = 4500,
                    PublisherId = 17,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 32,
                    Title = "ما به عشق محتاجیم!",
                    Shabak = "9786001180613",
                    Author = "مسیحا برزگر",
                    Description = "Description",
                    Release_Date = new DateTime(2022, 02, 08),
                    Price = 20000,
                    PublisherId = 23,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 33,
                    Title = "در زلالِ شعر",
                    Shabak = "9789646404106",
                    Author = "کامیار عابدی",
                    Description = "Description",
                    Release_Date = new DateTime(2021, 02, 04),
                    Price = 78000,
                    PublisherId = 10,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 34,
                    Title = "شب‌های حافظ",
                    Shabak = "9786007811863",
                    Author = "پدرام حکیم‌زاده",
                    Description = "Description",
                    Release_Date = new DateTime(2019, 02, 02),
                    Price = 6000,
                    PublisherId = 25,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 35,
                    Title = "رعشه شاعران",
                    Shabak = "9786227395969",
                    Author = "پدرام حکیم‌زاده",
                    Description = "Description",
                    Release_Date = new DateTime(2021, 02, 01),
                    Price = 14000,
                    PublisherId = 25,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 36,
                    Title = "افسونگر چرخ کبود",
                    Shabak = "9786007811757",
                    Author = "پدرام حکیم‌زاده",
                    Description = "Description",
                    Release_Date = new DateTime(2018, 02, 02),
                    Price = 12000,
                    PublisherId = 25,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 37,
                    Title = "صدای امواج",
                    Shabak = "9786007811764",
                    Author = "پدرام حکیم‌زاده ، مصلح‌بن عبدالله سعدی",
                    Description = "Description",
                    Release_Date = new DateTime(2018, 02, 02),
                    Price = 6000,
                    PublisherId = 25,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 38,
                    Title = "آن پایین چه خبر است؟",
                    Shabak = "9786008347170",
                    Author = "مک بارنت",
                    Description = "Description",
                    Release_Date = new DateTime(2018, 03, 02),
                    Price = 49000,
                    PublisherId = 14,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 39,
                    Title = "چتری برای دو نفر",
                    Shabak = "9786004622585",
                    Author = "جاناتان لاندِن",
                    Description = "Description",
                    Release_Date = new DateTime(2019, 03, 02),
                    Price = 49000,
                    PublisherId = 14,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 40,
                    Title = "ورود فیل‌ها ممنوع!",
                    Shabak = "9786004621144",
                    Author = "لیزا مَنچاو",
                    Description = "Description",
                    Release_Date = new DateTime(2018, 03, 02),
                    Price = 29000,
                    PublisherId = 14,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 41,
                    Title = "با احتیاط باز کنید. خطر گاز گرفتگی!",
                    Shabak = "9786004622523",
                    Author = "نیک براملی",
                    Description = "Description",
                    Release_Date = new DateTime(2019, 02, 28),
                    Price = 24000,
                    PublisherId = 14,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 42,
                    Title = "آدم برفی سردشه",
                    Shabak = "9786004623032",
                    Author = "مورین رایت",
                    Description = "Description",
                    Release_Date = new DateTime(2019, 02, 28),
                    Price = 49000,
                    PublisherId = 14,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 43,
                    Title = "تاریخچه مختصر زمان",
                    Shabak = "9786008866398",
                    Author = "استیون هاوکینگ",
                    Description = "Description",
                    Release_Date = new DateTime(2022, 03, 06),
                    Price = 8000,
                    PublisherId = 26,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 44,
                    Title = "بر فراز با فیلسوفان",
                    Shabak = "9786004614139",
                    Author = "ماری رابرت",
                    Description = "Description",
                    Release_Date = new DateTime(2021, 03, 04),
                    Price = 20000,
                    PublisherId = 16,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 45,
                    Title = "اندیشۀ پست مدرن",
                    Shabak = "9789643726195",
                    Author = "رضا داوری اردکانی",
                    Description = "Description",
                    Release_Date = new DateTime(2013, 01, 30),
                    Price = 25000,
                    PublisherId = 13,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 46,
                    Title = "جایگاه زیبایی در عالم هنر",
                    Shabak = "9786220403845",
                    Author = "الکساندر نهاماس",
                    Description = "Description",
                    Release_Date = new DateTime(2022, 01, 29),
                    Price = 35000,
                    PublisherId = 1,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 47,
                    Title = "سفر با اپیکور",
                    Shabak = "9786004613880",
                    Author = "دانیل ام. کلاین",
                    Description = "Description",
                    Release_Date = new DateTime(2021, 01, 29),
                    Price = 20000,
                    PublisherId = 16,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 48,
                    Title = "چنین گفت زرتشت",
                    Shabak = "9645620600",
                    Author = "فريدريش نيچه",
                    Description = "Description",
                    Release_Date = new DateTime(2017, 02, 21),
                    Price = 95000,
                    PublisherId = 18,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 49,
                    Title = "کوسهٔ شکم‌پر ۱۲ ‌میلیون دلاری",
                    Shabak = "9786226401203",
                    Author = "دُن تامپسون",
                    Description = "Description",
                    Release_Date = new DateTime(2019, 03, 06),
                    Price = 98000,
                    PublisherId = 27,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 50,
                    Title = "اعلان قرمز",
                    Shabak = "9786004611367",
                    Author = "بیل براودر",
                    Description = "Description",
                    Release_Date = new DateTime(2019, 01, 19),
                    Price = 55000,
                    PublisherId = 16,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 51,
                    Title = "آشنایی با بازارهای بورس انرژی",
                    Shabak = "9786008095866",
                    Author = "حسین سیلسپور",
                    Description = "Description",
                    Release_Date = new DateTime(2017, 01, 09),
                    Price = 35000,
                    PublisherId = 17,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Book
                {
                    Id = 52,
                    Title = "تجزیه و تحلیل کلان داده‌ها",
                    Shabak = "9786227393170",
                    Author = "آرویند ساتهی",
                    Description = "Description",
                    Release_Date = new DateTime(2020, 06, 21),
                    Price = 52000,
                    PublisherId = 28,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                }
            );

            #endregion
        }
    }
}
