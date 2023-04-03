using EShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Infrastructure.Data.Configurations
{
    public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasMany(b => b.Books)
                   .WithOne(p => p.Publisher);

            #region Seed Data Publisher

            builder.HasData(
                new Publisher
                {
                    Id = 1,
                    Name = "گروه انتشاراتی ققنوس",
                    Description =
                        "فروشگاه انتشارات ققنوس در بهمن‌ماه سال ١٣٥٦ آغاز به کار کرد، اما این آغازِ کار نبود: امیر حسین‌زادگان، مؤسس انتشارات، کارش را در این حوزه از سال ١٣٥٠، در یکی از محلات جنوب‌غربی تهران، مهرآباد جنوبی، و با راه‌اندازی کتابفروشی «امیر»، شروع کرد.",
                    Establishment_Date = new DateTime(1978, 01, 21),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 2,
                    Name = "نشر نون",
                    Description = "ندارد",
                    Establishment_Date = new DateTime(2012, 03, 20),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 3,
                    Name = "نشر قطره",
                    Description = @"نشر قطره یک مؤسسه انتشاراتی چاپ و نشر کتاب در ایران است که از سال ۱۳۶۷ آغاز به فعالیت نموده‌است. عناوین کتاب‌های نشر شده توسط این انتشاراتی شامل حوزه‌های مختلفی از جمله ادبیات داستانی داخلی و خارجی،[۱] نمایش‌نامه، داستان کوتاه، کتب آموزشی و غیره می‌گردد.",
                    Establishment_Date = new DateTime(1988, 03, 21),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 4,
                    Name = "نشر چشمه",
                    Description = @"نشر چشمه مؤسسات انتشاراتی در ایران که عمده فعالیتش در زمینه ادبیات است.[۱]
                    انتشارات چشمه فعالیت خود را برای انتشار کتاب از سال ۱۳۶۴ شروع کرد.[۲] مدیر این انتشارات سیّد حسن کیائیان موسوی است. این انتشارات در خرداد ۱۳۹۱ از سوی وزارت ارشاد لغو مجوز شد.[۳] و در زمان دولت یازدهم فعالیتش را از سر گرفت. انتشارات چشمه از زمان تأسیس در حوزه‌های مختلف هنر و ادبیات مانند داستان، شعر، نمایشنامه، فیلمنامه، سینما، تحقیقات ادبی، متون کهن، فلسفه، علوم اجتماعی، اسطوره و تاریخ فعالیت کرده‌است.",
                    Establishment_Date = new DateTime(1985, 03, 21),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 5,
                    Name = "انتشارات نقش و نگار",
                    Description = @"انتشارات نقش و نگار در سال 1373 توسط ابراهیم شهلایی مقدم تأسیس شد و تا به حال بیش از 50 عنوان کتاب در موضوعات عمومی منتشر کرده است.",
                    Establishment_Date = new DateTime(1994, 03, 21),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 6,
                    Name = "نشر شمشاد",
                    Description = "",
                    Establishment_Date = new DateTime(2013, 03, 21),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 7,
                    Name = "انتشارات نگاه نوین",
                    Description = "",
                    Establishment_Date = new DateTime(1978, 01, 21),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 8,
                    Name = "انتشارات درسا",
                    Description = @"انتشارات درسا از سال 1372 آغاز به کار کرد؛ اما شروع فعالیت فرهنگی این مجموعه به چند سال پیش از آن باز می‌گردد: مرحوم صمد رحیمیان، مؤسس و صاحب‌ امتیاز شرکت نشر و پخش ویس و انتشارات رسام، از سال 1364 فعالیت خود را با تولید کتاب‌هایی در حوزه‌ی علوم سیاسی، ادبیات داستانی، روان‌ شناسی و روان‌ شناسی نوین، در محل کنونی انتشارات درسا آغاز کرد.  در سال 1369 ایشان بنا به دلایلی ناگزیر شد شرکت نشر و پخش ویس را منحل کند. در همین سال به‌ اتفاق همسر و فرزندش (کیوان رحیمیان) نشر درسا را پایه‌گذاری کرد و در پی اخذ پروانه‌ی نشر جدید به نام همسرش در سال 1372، پس از پنج سال نشر لیوسا نیز با مدیریت و صاحب‌امتیازی کیوان رحیمیان وارد فعالیت رسمی در صنعت نشر ایران شد.",
                    Establishment_Date = new DateTime(1985, 03, 21),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 9,
                    Name = "نشر راویس",
                    Description = "",
                    Establishment_Date = new DateTime(1978, 01, 21),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 10,
                    Name = "نشر ثالث",
                    Description = @"نشر ثالث یک شرکت فعال در زمینه چاپ و نشر کتاب می‌باشد که از سال ۱۳۷۵ فعالیت خود را آغاز کرده‌است. این انتشاراتی آثار متعددی را عمدتاً در حوزه‌های علوم انسانی (ادبیات، دین، تاریخ، فلسفه، علوم اجتماعی، روان‌شناسی و هنر) منتشر کرده‌است.[۱][۲] از میان کتاب‌هایی که نشر ثالث منتشر کرده می‌توان به دون کیشوت اثر سروانتس با ترجمه‌ی محمد قاضی ، ریشه‌های توتالیتاریسم اثر هانا آرنت با ترجمه محسن ثلاثی و در حوزه رمان کتابخانه نیمه شب اثر مت هیگ با ترجمه امین حسینیون اشاره کرد.",
                    Establishment_Date = new DateTime(1996, 03, 20),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 11,
                    Name = "نشر بید",
                    Description = @"این انتشارات در آستانه فعالیت خود همواره این مهم را مدنظر داشته‌است که نه برای نبرد و رقابت بلکه برای پوشش‌دادن به خلأ موجود در دنیای فرهنگ و هنر پا به عرصه نشر می‌نهد. کمبودی که شاید در حال حاضر وجود آن به طور ملموس قابل درک نباشد؛ اما بدون شک در آینده خود را بیش از پیش نمایان و آشکار می‌سازد.",
                    Establishment_Date = new DateTime(2018, 03, 21),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 12,
                    Name = "انتشارات نسل روشن",
                    Description = @"انتشارات نسل روشن با مجوز رسمی از وزارت فرهنگ و ارشاد اسلامی و در اختیار داشتن خط تولید کامل چاپ کتاب (از تبدیل دست نوشته‌های صاحب اثر تا تحویل کتابی مرغوب و با کیفیت) و تجربه چاپ و انتشار بیش از ۱۰۰۰ عنوان کتاب در زمینه‌های مختلف(علمی، دانشگاهی، شعر،رمان و…) افتخار دارد در خدمت اساتید و نویسندگان عزیزی که تمایل دارند آثار و تالیفات خود را به ثبت برسانند باشد",
                    Establishment_Date = new DateTime(1978, 01, 21),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 13,
                    Name = "انتشارات سخن",
                    Description = @"تشارات سخن یکی از ناشران ایرانی است که در حوزه‌های تاریخ، علوم اجتماعی و علوم انسانی، فرهنگ و ادبیات فعالیت دارد.[۱]مدیریت این انتشارات بر عهدهٔ علی‌اصغر علمی است.[۲]تاکنون ۱۲ عنوان کتاب از انتشارات سخن به عنوان کتاب سال شناخته شده‌است.",
                    Establishment_Date = new DateTime(1990, 03, 21),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 14,
                    Name = "نشر پرتقال",
                    Description = @"ما انتشارات پرتقال هستیم، بچه‌ی انتشارات خیلی‌سبز!
                    یه خواهشی داشتیم... لطفا بزرگ نشید !
                    ما هم یه روز مثل شما و هم سن و سال شما بودیم؛ خوش‌حال بودیم و بی‌دلیل می‌خندیدیم!
                    تا اینکه یکی صدامون کرد... چپ چپ به بستنی توی دستمون و توپی که تو دست دیگه‌مون بود نگاه کرد،
                    مستقیم توی چشم‌هامون زل زد و گفت: «بهتره زودتر بزرگ بشید؛ بزرگ شدن و بزرگ بودن خیلی خوبه...»",
                    Establishment_Date = new DateTime(2016, 04, 20),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 15,
                    Name = "انتشارات کتاب همراه",
                    Description = "",
                    Establishment_Date = new DateTime(1978, 01, 21),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 16,
                    Name = "انتشارات کتاب کوله‌پشتی",
                    Description = @"نشر کتاب کوله‌پشتی یک مؤسسه انتشاراتی کتاب در ایران است که از سال ۱۳۹۰ فعالیتش را آغاز و عمده فعالیتش در زمینه ادبیات داخلی و خارجی است.[۱] شهرت این انتشاراتی از آنجایی است که برای نخستین مرتبه در ایران، کتاب‌های منتشر شده را دارای گارانتی رسمی نموده‌است[۲] این انتشاراتی همچنین در زمینه چاپ و نشر رمان و داستان بلند نیز با انتشار آثاری در این زمینه، نامزد جایزه ادبی جلال آل‌احمد سال ۱۳۹۷ گردیده‌است.",
                    Establishment_Date = new DateTime(2011, 03, 21),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 17,
                    Name = "انتشارات گیوا",
                    Description = @"انتشارات گیوا با چشم‌انداز بین‌المللی و با هدف اعتلای فرهنگ ایرانی از آبان ۱۳۹۴ کار خود را به عنوان ناشر مستقل در زمینه‌ی دانشگاهی آغاز کرد و یک‌سال بعد حوزه‌ی فعالیتش را در عرصه‌ی شعر و ادبیات و کتاب‌های عمومی نیز گستراند. گیوا با شعار «هر ایرانی یک کتاب»، با توکل به خدا و تکیه به اعتماد مردمان خوبمان تصمیم دارد در گام نخستِ چشم‌انداز ِ ایده‌آلیستی خود از هر ایرانی اهل قلم، کتابی به چاپ برساند و در گام دوم و به کمک آثار نویسندگان عزیز، موضوعات کتاب‌ها را تنوع‌بخشی کرده و با ورود بیشتر و بهتر به عرصه‌های شعر، ترانه، داستان، رمان، نقد و نظریه، فیلمنامه و نمایشنامه، منطق، فلسفه و روانشناسی، حقوق و علوم سیاسی، مدیریت و اقتصاد، تاریخ و هنر، علوم پایه و … ویترینی به وسعت ایران بزرگ و فراتر از آن تشکیل دهد تا هر نوع سلیقه‌‌ای را تامین نماید.",
                    Establishment_Date = new DateTime(2015, 10, 23),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 18,
                    Name = "انتشارات جامی",
                    Description = @"انتشارات جامی ناشر برترین کتابهای ادبی، هنری و تاریخی است .این نشر در سال ۱۳۶۹ تاسیس شد.
                    عمده فعالیت این نشر در زمینه ی ترجمه ی رمان های کلاسیک است. انتشارات مصدق و انتشارات فرهنگ برتر جزء موسسات انتشاراتی هستند که وابسته به نشر جامی فعالیت می کنند.
                    آثاری نویسندگانی چون جورج اورول، امیلی برونته، هاینریش بل، مارک تواین، شارلوت بروتنه، جوجو مویز، ارنست همینگوی و جین آستین در این انتشارات چاپ شده است.",
                    Establishment_Date = new DateTime(1990, 03, 21),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 19,
                    Name = "نشر نیماژ",
                    Description = @"مختصری در مورد نیماژ بدانید:
                    نیماژ؛ نشری‌ که فعالیت خود را سال 92 در زمينه‌ی شعر به‌صورت تخصصي آغاز کرده، جذابیت و امر چالش‌برانگیز شعر در سطوح مختلف جامعه را دلیلی بر انتخاب این حوزه برای آغاز فعالیت خود می‌داند. اما در سال 93 و ادامه‌ی آن این نشر با نگاهی متفاوت‌تر از شروع فعالیت خود،به انتشار عناوینی در زمینه‌ی ادبیات داستانی پرداخته، که در برگیرنده‌ی آثار نویسندگان ایرانی و خارجی‌ست در همین مسیر سرفصل‌هایی چون فلسفه و علوم اجتماعی را در سیاست‌های نشر کتاب خود تعریف کرد.",
                    Establishment_Date = new DateTime(2013, 03, 21),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 20,
                    Name = "انتشارات آزرمیدخت",
                    Description = "",
                    Establishment_Date = new DateTime(2009, 03, 21),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 21,
                    Name = "انتشارات ندای معاصر",
                    Description = "",
                    Establishment_Date = new DateTime(2017, 03, 21),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 22,
                    Name = "نشر پیکان",
                    Description = @"مدیریت این انتشارات از سال 1357 تا پایان سال 1358 رئیس حسابداری انتشارات امیرکبیر بوده و از آن سال به بعد با چند نفر از دوستان شرکت نشر نو را تأسیس کرده و مدیریت آن را به عهده داشته است.
                    در سال 1367 مدیریت انتشارات البرز را عهده ­دار بوده است و از سال 1375 تا امروز مدیر نشر پیکان است.
                    تاکنون بیش از دو هزار عنوان کتاب به مدیریت ایشان منتشر شده است و اکنون این انتشارات در حوزه ­های روان­شناسی، فلسفه، ادبیات ایران، ادبیات جهان، هنر، علم، تاریخ، سیاست و … فعالیت دارد.",
                    Establishment_Date = new DateTime(1996, 03, 20),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 23,
                    Name = "انتشارات ذهن‌ آویز",
                    Description = "",
                    Establishment_Date = new DateTime(1978, 01, 21),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 24,
                    Name = "نشر ترنگ",
                    Description = @"نشر ترنگ در سال 1394 با هدف جذب مخاطبان در حوزه روان درمانگري و عرفان تاسيس شد. اين نشر تاکنون تمرکز اصلي خود را بر ارتقاء سطح کيفي زندگي ايرانيان متمرکز کرده است و با اتکا به شناخت خود از دغدغه هاي خانواده هاي ايراني سعي در چاپ کتب متنوع در زمينه بيداري، خودآگاهي و سلامت روان داشته است به مدد حمايت شما سروران گرامي اين نشر با قدرت به مسير خود ادامه مي دهد و با چاپ کتب مناسب از شناخته شده ترين مولفان، زمينه بهبود روند زندگي و سلامت رواني مخاطبان خود را مطالبه خواهد کرد.",
                    Establishment_Date = new DateTime(2015, 03, 21),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 25,
                    Name = "انتشارات شهر پدرام",
                    Description = "",
                    Establishment_Date = new DateTime(2013, 03, 21),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 26,
                    Name = "انتشارات زرین کلک",
                    Description = "",
                    Establishment_Date = new DateTime(1978, 01, 21),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 27,
                    Name = "نشر بیدگل",
                    Description = @"تنها یک سرک کوچک به سایت bidgolpublishing.com کافی‌ست که با نشر جذاب و خوش‌سلیقهٔ «بیدگل» آشنا شوید و تصمیم بگیرید توی عناوین کتاب‌های منتشرشده‌اش بچرخید. این انتشارات که توسط آقای «محمدحسن شاطریان بیدگلی» تاسیس شده، و احتمالاً اسم زیبایش را هم وامدار نام خانوداگی ایشان است، در زمینه‌های گوناگونی کتاب منتشر می‌کند که با یک مرور کلی روی عناوین آثار منتشرشده‌اش، می‌بینیم که اغلب این کتاب‌ها در حوزهٔ سینما، ادبیات، تئاتر، ادبیات داستانی، نگارش خلاق، دانش زندگی، هنرهای نمایشی و تاریخچهٔ آن‌ها، هنرهای تجسمی، دانش عمومی و مواردی از این دست به‌طور تخصصی، قرار می‌گیرند.",
                    Establishment_Date = new DateTime(2007, 03, 21),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Publisher
                {
                    Id = 28,
                    Name = "فناوری نوین",
                    Description = "",
                    Establishment_Date = new DateTime(1978, 01, 21),
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                }
            );

            #endregion
        }
    }
}