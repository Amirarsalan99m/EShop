using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EShop.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddBookModelsAndRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Establishment_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shabak = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Release_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    PublisherId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookCategories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<long>(type: "bigint", nullable: false),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookCategories_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateDate", "Description", "IsDeleted", "LastUpdateDate", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 3, 25, 11, 52, 24, 677, DateTimeKind.Local).AddTicks(9447), "داستان‌ها در ادبیات جهان سابقه دور و درازی دارند. این روایت‌ها از زمانی که قصه‌ها سینه به سینه منتقل می‌شدند وجود دارند تا ادبیات معاصر امروز. در هیچ دوره‌ای انسان‌ها بی نیاز از داستان‌ها نیستند. زیرا شیرینی بی‌نظیر و تکرار نشدنی در این وجود دارد که در خیال دیگران غرق شویم و تجربیات ناب لحظه‌های دیگران را مال خود بدانیم.\r\n                داستان محصول ذهن خلاق فردی به نام نویسنده است که شخصیت‌های داستانش را ساخته و پرداخته و به زبان ادبی روایت می‌کند.یک داستان خوب می‌تواند مسیر زندگی شما را تغییر دهد؛ زیرا آموزه های آن در زندگی واقعی کاربرد فراوانی دارد.کتاب به انسان آگاهی می دهد و از تکرار خطاها و کج روی ها پیش گیری می کند.با مطالعه کتب داستانی متنوع می توانیم از حقوق فردی و اجتماعی خود آگاه شویم و از آن دفاع کنیم.\r\n                هم چنین کتاب‌خوانی به کتاب‌خوان فرصت می‌دهد تا بدونِ پرداخت هزینه مالی و جانی‌ که نویسنده یا شخصیت‌های کتاب پرداخت کرده‌اند، تجربه آن‌ها را مال خود کند.این محکم‌ترین دلیل برای کتاب‌خوانی‌ست.جالب است بدانید که با مطالعه مشهورترین رمان های دنیا از سبک زندگی انسان ها در سراسر دنیا آشنا می شویم و می توانیم نقاط مثبت هر یک را در روزمره خود به کار بندیم.", false, new DateTime(2023, 3, 25, 11, 52, 24, 677, DateTimeKind.Local).AddTicks(9479), "داستان و رمان" },
                    { 2L, new DateTime(2023, 3, 25, 11, 52, 24, 677, DateTimeKind.Local).AddTicks(9483), "دانش روانشناسی، دانشی است که از نیمه‌ی دوم قرن هفدهم ظهور کرده و شاخه‌های متنوعی دارد. افرادی مانند ژان پیاژه، زیگموند فروید، کارال راجرز و گوستاو یونگ عمرشان را صرف کرده‌اند تا مفاهیم این دانش را تکمیل کنند و از آن برای کمک به بشر در مسیر یک زندگی بهتر بهره ببرند.\r\nدر دنیای امروز که زندگی بسیار پرمشغله‌تر از گذشته شده و روابط پیچیده‌تر شده‌اند همه‌ی افراد به این دانش نیاز دارند. نیاز به خودشناسی در دنیای ما که رسانه‌های مختلف انواع محتوا را به خوردمان می‌دهند و معیارهای متعددی را برای خوشبختی و موفقیت معرفی می‌کنند بسیار بیشتر از گذشته است. امروزه برای یک ازدواج موفق درک درست از شخصیت خودمان و طرف مقابل ضروری است و برای داشتن یک خانواده‌ی سالم نیاز داریم اصول تربیتی را بهتر فرا بگیریم. استفاده از روانشناس بالینی بسیار مفید است اما ممکن است همه به چنین شرایط دسترسی نداشته باشند. جای نگرانی نیست، این روزها دیگر کتاب‌های روانشناسی فقط به کتاب‌های دانشگاهی که مخصوص دانشجویان و متخصصان هستند محدود نمی‌شوند و انواع کتاب فیزیکی و صوتی برای گروه‌های مختلف نوشته‌شده‌اند و به‌ راحتی می‌توانید متناسب با نیازتان یک گزینه‌ی خوب را انتخاب کنید.", false, new DateTime(2023, 3, 25, 11, 52, 24, 677, DateTimeKind.Local).AddTicks(9484), "روانشناسی" },
                    { 3L, new DateTime(2023, 3, 25, 11, 52, 24, 677, DateTimeKind.Local).AddTicks(9485), "شعر کلامی تاثیر گذار و سخنی خیال انگیز است که موزون سروده می شود. از زمانی که انسان با مفهوم شعر آشنا شده است همواره آن را آهنگین یافته و مسحور و مفتون آن گشته است.  شاعر نقاش زبردستی است که خوبی ها و بدی ها را به زیبایی در قالب کلمات موزون به تصویر می کشد و با سرودن اشعار لطیف و بدیع توجه همگان را به شعر معطوف می دارد.\r\nدر این میان همواره شعر های عاشقانه و احساسی در طول تاریخ مورد توجه بسیار بوده اند و داستان ها و حکایت های عاشقانه بسیاری به صورت نظم در ادبیات کهن ایران برجای مانده است که در میان آن ها می توان به کتب شعر عاشقانه خسرو و شیرین، لیلی و مجنون و شیرین و فرهاد اشاره کرد.", false, new DateTime(2023, 3, 25, 11, 52, 24, 677, DateTimeKind.Local).AddTicks(9486), "شعر" },
                    { 4L, new DateTime(2023, 3, 25, 11, 52, 24, 677, DateTimeKind.Local).AddTicks(9487), "اهمیت آموزش کودکان و پرورش ذهن آن‌ها برای درک جهانی که در آن زندگی می‌کنند بر کسی پوشیده نیست. کودکان به‌واسطه‌ی کتاب‌ها و دیگر انواع محتوا با پدیده‌های گوناگون آشنا می‌شوند و باعث درک بهتر آنها از پیرامون خود می‌شود تا بتوانند در موقعیت‌های مختلف واکنش مناسبی از خود نشان دهند. کودکان قشری هستند که معمولاً خودشان محتوا را انتخاب نمی‌کنند و نقش خانواده و مربی در معرفی و تهیه آن بسیار زیاد است. برای همین کسب آگاهی و انتخاب محتوای مناسب برای کودکان توسط والدین و خانواده بسیار حائز اهمیت است. کودکان با مطالعه‌ی کتاب‌های علمی می‌توانند پاسخ سوالات خود را پیدا کنند و یا کنجکاو شوند. همچنین کتاب‌های داستان و رمان می‌تواند به آن‌ها کمک کند تا با شخصیت‌های بیشتری آشنا شوند و تجربیات بیشتری کسب کنند و از همه مهم‌تر قوه‌ی تخیل کودکان نیز رشد پیدا کند. یکی از مواردی که باید در خرید کتاب کودک به آن توجه کنیم رده‌ی سنی است.", false, new DateTime(2023, 3, 25, 11, 52, 24, 677, DateTimeKind.Local).AddTicks(9488), "کودک" },
                    { 5L, new DateTime(2023, 3, 25, 11, 52, 24, 677, DateTimeKind.Local).AddTicks(9490), "اگر بخواهیم از تعریف کلمه‌ی فلسفه شروع کنیم این کلمه از کلمه‌ی یونانی فیلوسوفیا گرفته شده است و طبق تعریف ویکی پدیا به‌معنای مطالعه پرسش‌های بنیادین عالم است. تاریخ فلسفه تاریخ پر فراز و نشیبی است که از زمان سقراط اولین فیلسوف بزرگ یونان آغاز شده و با افرادی مانند فردریش نیچه، برتراند راسل و ویل دورانت تا امروز ادامه داشته و گسترده شده است. امروز اگر بخواهیم از فلسفه حرف بزنیم باید بدانیم منظورمان فلسفه‌ی غرب است که در یونان ریشه دارد یا می‌خواهیم از فلسفه‌ی شرق حرف بزنیم؟ فلسفه دیگر مانند گذشته محدود نیست و آثار فلسفی هم موضوعات زیادی از فلسفه اخلاق و فلسفه سیاسی تا فلسفه اسلامی و ... را پوشش می‌دهند. گروهی از فلاسفه معتقدند فلسفه تنها متعلق به فیلسوفان است و در زندگی مردم عادی نقشی ندارد اما گروهی هم تلاش کرده‌اند با معرفی کتاب‌هایی مانند رمان‌های فلسفی یا کتاب‌های فلسفی روانشناسی آن را با زندگی روزمره بیامیزند و همین باعث تنوع در آثار فلسفی شده است. ", false, new DateTime(2023, 3, 25, 11, 52, 24, 677, DateTimeKind.Local).AddTicks(9491), "فلسفه" },
                    { 6L, new DateTime(2023, 3, 25, 11, 52, 24, 677, DateTimeKind.Local).AddTicks(9492), "اقتصاد در بطن زندگی انسان ریشه دوانده و زندگی روزمره را به شدت تحت تاثیر قرار داده است. ما بدون آنکه به علم اقتصاد و پیچیدگی‌های آن بیاندیشیم، تصمیم‌هایی می‌گیریم که اقتصاد آن را اداره می‌کند. مقایسه‌ی تورهای مسافرتی، خرید اشتراک اینترنت، تعویض ماشین همه و همه به محاسبات اقتصادی و نوع نگاه ما به آن بستگی دارد. علم اقتصاد به زبان ساده به این شکل تعریف می‌شود: یک نظام اقتصادی مربوط به یک منطقه سیاسی یا جغرافیایی خاص است و تولید، توزیع و مصرف کالا و خدمات را دربرمی‌گیرد. در اقتصاد 4 عامل نقش کلیدی ایفا می‌کند: منابع انسانی، منابع مالی، زمین و کسب و کار", false, new DateTime(2023, 3, 25, 11, 52, 24, 677, DateTimeKind.Local).AddTicks(9493), "اقتصاد" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "CreateDate", "Description", "Establishment_Date", "IsDeleted", "LastUpdateDate", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(194), "فروشگاه انتشارات ققنوس در بهمن‌ماه سال ١٣٥٦ آغاز به کار کرد، اما این آغازِ کار نبود: امیر حسین‌زادگان، مؤسس انتشارات، کارش را در این حوزه از سال ١٣٥٠، در یکی از محلات جنوب‌غربی تهران، مهرآباد جنوبی، و با راه‌اندازی کتابفروشی «امیر»، شروع کرد.", new DateTime(1978, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(197), "گروه انتشاراتی ققنوس" },
                    { 2L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(202), "ندارد", new DateTime(2012, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(203), "نشر نون" },
                    { 3L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(205), "نشر قطره یک مؤسسه انتشاراتی چاپ و نشر کتاب در ایران است که از سال ۱۳۶۷ آغاز به فعالیت نموده‌است. عناوین کتاب‌های نشر شده توسط این انتشاراتی شامل حوزه‌های مختلفی از جمله ادبیات داستانی داخلی و خارجی،[۱] نمایش‌نامه، داستان کوتاه، کتب آموزشی و غیره می‌گردد.", new DateTime(1988, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(206), "نشر قطره" },
                    { 4L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(207), "نشر چشمه مؤسسات انتشاراتی در ایران که عمده فعالیتش در زمینه ادبیات است.[۱]\r\n                    انتشارات چشمه فعالیت خود را برای انتشار کتاب از سال ۱۳۶۴ شروع کرد.[۲] مدیر این انتشارات سیّد حسن کیائیان موسوی است. این انتشارات در خرداد ۱۳۹۱ از سوی وزارت ارشاد لغو مجوز شد.[۳] و در زمان دولت یازدهم فعالیتش را از سر گرفت. انتشارات چشمه از زمان تأسیس در حوزه‌های مختلف هنر و ادبیات مانند داستان، شعر، نمایشنامه، فیلمنامه، سینما، تحقیقات ادبی، متون کهن، فلسفه، علوم اجتماعی، اسطوره و تاریخ فعالیت کرده‌است.", new DateTime(1985, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(208), "نشر چشمه" },
                    { 5L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(210), "انتشارات نقش و نگار در سال 1373 توسط ابراهیم شهلایی مقدم تأسیس شد و تا به حال بیش از 50 عنوان کتاب در موضوعات عمومی منتشر کرده است.", new DateTime(1994, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(211), "انتشارات نقش و نگار" },
                    { 6L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(212), "", new DateTime(2013, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(213), "نشر شمشاد" },
                    { 7L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(215), "", new DateTime(1978, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(216), "انتشارات نگاه نوین" },
                    { 8L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(217), "انتشارات درسا از سال 1372 آغاز به کار کرد؛ اما شروع فعالیت فرهنگی این مجموعه به چند سال پیش از آن باز می‌گردد: مرحوم صمد رحیمیان، مؤسس و صاحب‌ امتیاز شرکت نشر و پخش ویس و انتشارات رسام، از سال 1364 فعالیت خود را با تولید کتاب‌هایی در حوزه‌ی علوم سیاسی، ادبیات داستانی، روان‌ شناسی و روان‌ شناسی نوین، در محل کنونی انتشارات درسا آغاز کرد.  در سال 1369 ایشان بنا به دلایلی ناگزیر شد شرکت نشر و پخش ویس را منحل کند. در همین سال به‌ اتفاق همسر و فرزندش (کیوان رحیمیان) نشر درسا را پایه‌گذاری کرد و در پی اخذ پروانه‌ی نشر جدید به نام همسرش در سال 1372، پس از پنج سال نشر لیوسا نیز با مدیریت و صاحب‌امتیازی کیوان رحیمیان وارد فعالیت رسمی در صنعت نشر ایران شد.", new DateTime(1985, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(218), "انتشارات درسا" },
                    { 9L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(219), "", new DateTime(1978, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(220), "نشر راویس" },
                    { 10L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(222), "نشر ثالث یک شرکت فعال در زمینه چاپ و نشر کتاب می‌باشد که از سال ۱۳۷۵ فعالیت خود را آغاز کرده‌است. این انتشاراتی آثار متعددی را عمدتاً در حوزه‌های علوم انسانی (ادبیات، دین، تاریخ، فلسفه، علوم اجتماعی، روان‌شناسی و هنر) منتشر کرده‌است.[۱][۲] از میان کتاب‌هایی که نشر ثالث منتشر کرده می‌توان به دون کیشوت اثر سروانتس با ترجمه‌ی محمد قاضی ، ریشه‌های توتالیتاریسم اثر هانا آرنت با ترجمه محسن ثلاثی و در حوزه رمان کتابخانه نیمه شب اثر مت هیگ با ترجمه امین حسینیون اشاره کرد.", new DateTime(1996, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(223), "نشر ثالث" },
                    { 11L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(224), "این انتشارات در آستانه فعالیت خود همواره این مهم را مدنظر داشته‌است که نه برای نبرد و رقابت بلکه برای پوشش‌دادن به خلأ موجود در دنیای فرهنگ و هنر پا به عرصه نشر می‌نهد. کمبودی که شاید در حال حاضر وجود آن به طور ملموس قابل درک نباشد؛ اما بدون شک در آینده خود را بیش از پیش نمایان و آشکار می‌سازد.", new DateTime(2018, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(225), "نشر بید" },
                    { 12L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(226), "انتشارات نسل روشن با مجوز رسمی از وزارت فرهنگ و ارشاد اسلامی و در اختیار داشتن خط تولید کامل چاپ کتاب (از تبدیل دست نوشته‌های صاحب اثر تا تحویل کتابی مرغوب و با کیفیت) و تجربه چاپ و انتشار بیش از ۱۰۰۰ عنوان کتاب در زمینه‌های مختلف(علمی، دانشگاهی، شعر،رمان و…) افتخار دارد در خدمت اساتید و نویسندگان عزیزی که تمایل دارند آثار و تالیفات خود را به ثبت برسانند باشد", new DateTime(1978, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(227), "انتشارات نسل روشن" },
                    { 13L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(229), "تشارات سخن یکی از ناشران ایرانی است که در حوزه‌های تاریخ، علوم اجتماعی و علوم انسانی، فرهنگ و ادبیات فعالیت دارد.[۱]مدیریت این انتشارات بر عهدهٔ علی‌اصغر علمی است.[۲]تاکنون ۱۲ عنوان کتاب از انتشارات سخن به عنوان کتاب سال شناخته شده‌است.", new DateTime(1990, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(230), "انتشارات سخن" },
                    { 14L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(231), "ما انتشارات پرتقال هستیم، بچه‌ی انتشارات خیلی‌سبز!\r\n                    یه خواهشی داشتیم... لطفا بزرگ نشید !\r\n                    ما هم یه روز مثل شما و هم سن و سال شما بودیم؛ خوش‌حال بودیم و بی‌دلیل می‌خندیدیم!\r\n                    تا اینکه یکی صدامون کرد... چپ چپ به بستنی توی دستمون و توپی که تو دست دیگه‌مون بود نگاه کرد،\r\n                    مستقیم توی چشم‌هامون زل زد و گفت: «بهتره زودتر بزرگ بشید؛ بزرگ شدن و بزرگ بودن خیلی خوبه...»", new DateTime(2016, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(232), "نشر پرتقال" },
                    { 15L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(233), "", new DateTime(1978, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(234), "انتشارات کتاب همراه" },
                    { 16L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(236), "نشر کتاب کوله‌پشتی یک مؤسسه انتشاراتی کتاب در ایران است که از سال ۱۳۹۰ فعالیتش را آغاز و عمده فعالیتش در زمینه ادبیات داخلی و خارجی است.[۱] شهرت این انتشاراتی از آنجایی است که برای نخستین مرتبه در ایران، کتاب‌های منتشر شده را دارای گارانتی رسمی نموده‌است[۲] این انتشاراتی همچنین در زمینه چاپ و نشر رمان و داستان بلند نیز با انتشار آثاری در این زمینه، نامزد جایزه ادبی جلال آل‌احمد سال ۱۳۹۷ گردیده‌است.", new DateTime(2011, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(237), "انتشارات کتاب کوله‌پشتی" },
                    { 17L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(238), "انتشارات گیوا با چشم‌انداز بین‌المللی و با هدف اعتلای فرهنگ ایرانی از آبان ۱۳۹۴ کار خود را به عنوان ناشر مستقل در زمینه‌ی دانشگاهی آغاز کرد و یک‌سال بعد حوزه‌ی فعالیتش را در عرصه‌ی شعر و ادبیات و کتاب‌های عمومی نیز گستراند. گیوا با شعار «هر ایرانی یک کتاب»، با توکل به خدا و تکیه به اعتماد مردمان خوبمان تصمیم دارد در گام نخستِ چشم‌انداز ِ ایده‌آلیستی خود از هر ایرانی اهل قلم، کتابی به چاپ برساند و در گام دوم و به کمک آثار نویسندگان عزیز، موضوعات کتاب‌ها را تنوع‌بخشی کرده و با ورود بیشتر و بهتر به عرصه‌های شعر، ترانه، داستان، رمان، نقد و نظریه، فیلمنامه و نمایشنامه، منطق، فلسفه و روانشناسی، حقوق و علوم سیاسی، مدیریت و اقتصاد، تاریخ و هنر، علوم پایه و … ویترینی به وسعت ایران بزرگ و فراتر از آن تشکیل دهد تا هر نوع سلیقه‌‌ای را تامین نماید.", new DateTime(2015, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(239), "انتشارات گیوا" },
                    { 18L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(240), "انتشارات جامی ناشر برترین کتابهای ادبی، هنری و تاریخی است .این نشر در سال ۱۳۶۹ تاسیس شد.\r\n                    عمده فعالیت این نشر در زمینه ی ترجمه ی رمان های کلاسیک است. انتشارات مصدق و انتشارات فرهنگ برتر جزء موسسات انتشاراتی هستند که وابسته به نشر جامی فعالیت می کنند.\r\n                    آثاری نویسندگانی چون جورج اورول، امیلی برونته، هاینریش بل، مارک تواین، شارلوت بروتنه، جوجو مویز، ارنست همینگوی و جین آستین در این انتشارات چاپ شده است.", new DateTime(1990, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(241), "انتشارات جامی" },
                    { 19L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(243), "مختصری در مورد نیماژ بدانید:\r\n                    نیماژ؛ نشری‌ که فعالیت خود را سال 92 در زمينه‌ی شعر به‌صورت تخصصي آغاز کرده، جذابیت و امر چالش‌برانگیز شعر در سطوح مختلف جامعه را دلیلی بر انتخاب این حوزه برای آغاز فعالیت خود می‌داند. اما در سال 93 و ادامه‌ی آن این نشر با نگاهی متفاوت‌تر از شروع فعالیت خود،به انتشار عناوینی در زمینه‌ی ادبیات داستانی پرداخته، که در برگیرنده‌ی آثار نویسندگان ایرانی و خارجی‌ست در همین مسیر سرفصل‌هایی چون فلسفه و علوم اجتماعی را در سیاست‌های نشر کتاب خود تعریف کرد.", new DateTime(2013, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(243), "نشر نیماژ" },
                    { 20L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(245), "", new DateTime(2009, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(246), "انتشارات آزرمیدخت" },
                    { 21L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(247), "", new DateTime(2017, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(248), "انتشارات ندای معاصر" },
                    { 22L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(250), "مدیریت این انتشارات از سال 1357 تا پایان سال 1358 رئیس حسابداری انتشارات امیرکبیر بوده و از آن سال به بعد با چند نفر از دوستان شرکت نشر نو را تأسیس کرده و مدیریت آن را به عهده داشته است.\r\n                    در سال 1367 مدیریت انتشارات البرز را عهده ­دار بوده است و از سال 1375 تا امروز مدیر نشر پیکان است.\r\n                    تاکنون بیش از دو هزار عنوان کتاب به مدیریت ایشان منتشر شده است و اکنون این انتشارات در حوزه ­های روان­شناسی، فلسفه، ادبیات ایران، ادبیات جهان، هنر، علم، تاریخ، سیاست و … فعالیت دارد.", new DateTime(1996, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(250), "نشر پیکان" },
                    { 23L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(252), "", new DateTime(1978, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(253), "انتشارات ذهن‌ آویز" },
                    { 24L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(254), "نشر ترنگ در سال 1394 با هدف جذب مخاطبان در حوزه روان درمانگري و عرفان تاسيس شد. اين نشر تاکنون تمرکز اصلي خود را بر ارتقاء سطح کيفي زندگي ايرانيان متمرکز کرده است و با اتکا به شناخت خود از دغدغه هاي خانواده هاي ايراني سعي در چاپ کتب متنوع در زمينه بيداري، خودآگاهي و سلامت روان داشته است به مدد حمايت شما سروران گرامي اين نشر با قدرت به مسير خود ادامه مي دهد و با چاپ کتب مناسب از شناخته شده ترين مولفان، زمينه بهبود روند زندگي و سلامت رواني مخاطبان خود را مطالبه خواهد کرد.", new DateTime(2015, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(255), "نشر ترنگ" },
                    { 25L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(256), "", new DateTime(2013, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(257), "انتشارات شهر پدرام" },
                    { 26L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(259), "", new DateTime(1978, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(260), "انتشارات زرین کلک" },
                    { 27L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(261), "تنها یک سرک کوچک به سایت bidgolpublishing.com کافی‌ست که با نشر جذاب و خوش‌سلیقهٔ «بیدگل» آشنا شوید و تصمیم بگیرید توی عناوین کتاب‌های منتشرشده‌اش بچرخید. این انتشارات که توسط آقای «محمدحسن شاطریان بیدگلی» تاسیس شده، و احتمالاً اسم زیبایش را هم وامدار نام خانوداگی ایشان است، در زمینه‌های گوناگونی کتاب منتشر می‌کند که با یک مرور کلی روی عناوین آثار منتشرشده‌اش، می‌بینیم که اغلب این کتاب‌ها در حوزهٔ سینما، ادبیات، تئاتر، ادبیات داستانی، نگارش خلاق، دانش زندگی، هنرهای نمایشی و تاریخچهٔ آن‌ها، هنرهای تجسمی، دانش عمومی و مواردی از این دست به‌طور تخصصی، قرار می‌گیرند.", new DateTime(2007, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(262), "نشر بیدگل" },
                    { 28L, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(263), "", new DateTime(1978, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(264), "فناوری نوین" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CreateDate", "IsDeleted", "LastUpdateDate", "Price", "PublisherId", "Release_Date", "Shabak", "Title" },
                values: new object[,]
                {
                    { 1L, "الیف شافاک", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(606), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(608), 95000, 1L, new DateTime(2015, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "9789643119195", "عاشقانه ملت عشق" },
                    { 2L, "فردریک بکمن", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(611), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(612), 95000, 2L, new DateTime(2016, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786007141779", "مردی به نام اوه" },
                    { 3L, "اروین یالوم", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(613), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(614), 65000, 3L, new DateTime(2020, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786001192029", "وقتی نیچه گریست" },
                    { 4L, "استیو تولتز", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(616), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(617), 160000, 4L, new DateTime(2016, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786002295002", "جزء از کل" },
                    { 5L, "ژان تولی", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(619), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(620), 38000, 4L, new DateTime(2018, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786002298812", "مغازه خودکشی" },
                    { 6L, "جورج اورول‌", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(622), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(622), 5000, 15L, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "964604799", "مزرعۀ حیوانات" },
                    { 7L, "شارون گاسکین", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(624), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(625), 55000, 16L, new DateTime(2020, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786004613644", "زمان فراموشی" },
                    { 8L, "پم مونیوس رایان", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(627), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(628), 49000, 14L, new DateTime(2019, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786004624763", "از سرزمین‌های انگور" },
                    { 9L, "دبورا ھاپکینسن", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(629), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(630), 49000, 14L, new DateTime(2019, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786004625104", "گوشه‌ی دنج کلاس" },
                    { 10L, "صادق هدایت", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(632), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(633), 8500, 17L, new DateTime(2020, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786004516464", "سه قطره خون" },
                    { 11L, "ام. تی. ادواردسن", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(635), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(636), 70000, 16L, new DateTime(2020, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786004613637", "یک خانوادۀ تقریباً معمولی" },
                    { 12L, "ژاک شابان", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(638), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(639), 12000, 18L, new DateTime(2015, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786001760112", "شب ترمیدور" },
                    { 13L, "الیف شافاک", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(640), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(641), 69000, 19L, new DateTime(2017, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786003672765", "اسکندر" },
                    { 14L, "فیودور داستایوفسکی", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(643), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(644), 16000, 18L, new DateTime(2022, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "9789642575398", "رویای عمو جان" },
                    { 15L, "جینین ساندرز ، کریگ اسمیت", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(645), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(646), 49000, 14L, new DateTime(2019, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786004623377", "بعضی از رازها را نباید نگه‌داشت" },
                    { 16L, "رابین شارما", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(648), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(649), 158000, 20L, new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786226242226", "باشگاه پنج صبحی‌‌ها" },
                    { 17L, "استیون هاوکینگ", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(651), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(652), 8000, 21L, new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786009896196", "جهان در پوست گردو" },
                    { 18L, "ليليان گلاس", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(654), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(655), 8000, 21L, new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786009896356", "آدم های سمی" },
                    { 19L, "دارن هاردی", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(657), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(657), 8000, 21L, new DateTime(2020, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786009896141", "اثر مرکب" },
                    { 20L, "شلی استايل", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(659), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(660), 15000, 22L, new DateTime(2016, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "9789643288464", "بعد از طلاق" },
                    { 21L, "آرون تی‌بک", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(662), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(663), 35000, 23L, new DateTime(2018, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "9789647390569", "عشق هرگز کافی نیست" },
                    { 22L, "چارلز هانل", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(665), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(666), 25000, 23L, new DateTime(2011, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786001180248", "شاه کلید" },
                    { 23L, "استیون میچل ، بایرون کیتی", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(668), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(669), 95000, 24L, new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786226683661", "هزار و یک‌دلیل برای شادبودن" },
                    { 24L, "نسرین دانائی", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(671), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(672), 25000, 13L, new DateTime(2020, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "9789643729691", "مدیریت هیجان" },
                    { 25L, "ریچل هالیس", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(674), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(675), 64000, 20L, new DateTime(2020, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786226242233", "صورتت را بشور دختر" },
                    { 26L, "جیم ران", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(677), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(678), 20000, 23L, new DateTime(2018, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786001182136", "فلسفۀ زندگی موفق" },
                    { 27L, "روندا برن", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(679), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(680), 45000, 23L, new DateTime(2015, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786001181528", "قهرمان" },
                    { 28L, "سهراب سپهری", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(682), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(683), 10000, 13L, new DateTime(2004, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "964372056x", "عاشق همیشه تنهاست" },
                    { 29L, "علی باباچاهی", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(685), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(686), 68000, 10L, new DateTime(2020, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "9789647230018", "این بانگ دلاویز" },
                    { 30L, "سیّد رضا محمدی", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(688), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(688), 9000, 16L, new DateTime(2018, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786004610650", "سفرنامۀ باد" },
                    { 31L, "مصطفی سپهری‌نیا", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(691), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(692), 4500, 17L, new DateTime(2020, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786004514552", "خواب‌های مرگ‌آلود" },
                    { 32L, "مسیحا برزگر", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(694), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(695), 20000, 23L, new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786001180613", "ما به عشق محتاجیم!" },
                    { 33L, "کامیار عابدی", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(696), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(697), 78000, 10L, new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "9789646404106", "در زلالِ شعر" },
                    { 34L, "پدرام حکیم‌زاده", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(699), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(700), 6000, 25L, new DateTime(2019, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786007811863", "شب‌های حافظ" },
                    { 35L, "پدرام حکیم‌زاده", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(701), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(702), 14000, 25L, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786227395969", "رعشه شاعران" },
                    { 36L, "پدرام حکیم‌زاده", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(704), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(705), 12000, 25L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786007811757", "افسونگر چرخ کبود" },
                    { 37L, "پدرام حکیم‌زاده ، مصلح‌بن عبدالله سعدی", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(706), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(707), 6000, 25L, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786007811764", "صدای امواج" },
                    { 38L, "مک بارنت", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(710), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(711), 49000, 14L, new DateTime(2018, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786008347170", "آن پایین چه خبر است؟" },
                    { 39L, "جاناتان لاندِن", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(712), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(713), 49000, 14L, new DateTime(2019, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786004622585", "چتری برای دو نفر" },
                    { 40L, "لیزا مَنچاو", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(715), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(716), 29000, 14L, new DateTime(2018, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786004621144", "ورود فیل‌ها ممنوع!" },
                    { 41L, "نیک براملی", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(718), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(719), 24000, 14L, new DateTime(2019, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786004622523", "با احتیاط باز کنید. خطر گاز گرفتگی!" },
                    { 42L, "مورین رایت", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(750), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(751), 49000, 14L, new DateTime(2019, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786004623032", "آدم برفی سردشه" },
                    { 43L, "استیون هاوکینگ", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(753), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(753), 8000, 26L, new DateTime(2022, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786008866398", "تاریخچه مختصر زمان" },
                    { 44L, "ماری رابرت", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(755), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(756), 20000, 16L, new DateTime(2021, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786004614139", "بر فراز با فیلسوفان" },
                    { 45L, "رضا داوری اردکانی", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(758), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(759), 25000, 13L, new DateTime(2013, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "9789643726195", "اندیشۀ پست مدرن" },
                    { 46L, "الکساندر نهاماس", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(760), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(761), 35000, 1L, new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786220403845", "جایگاه زیبایی در عالم هنر" },
                    { 47L, "دانیل ام. کلاین", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(763), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(763), 20000, 16L, new DateTime(2021, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786004613880", "سفر با اپیکور" },
                    { 48L, "فريدريش نيچه", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(765), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(766), 95000, 18L, new DateTime(2017, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "9645620600", "چنین گفت زرتشت" },
                    { 49L, "دُن تامپسون", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(769), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(770), 98000, 27L, new DateTime(2019, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786226401203", "کوسهٔ شکم‌پر ۱۲ ‌میلیون دلاری" },
                    { 50L, "بیل براودر", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(772), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(773), 55000, 16L, new DateTime(2019, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786004611367", "اعلان قرمز" },
                    { 51L, "حسین سیلسپور", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(774), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(775), 35000, 17L, new DateTime(2017, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786008095866", "آشنایی با بازارهای بورس انرژی" },
                    { 52L, "آرویند ساتهی", new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(777), false, new DateTime(2023, 3, 25, 11, 52, 24, 678, DateTimeKind.Local).AddTicks(777), 52000, 28L, new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "9786227393170", "تجزیه و تحلیل کلان داده‌ها" }
                });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "Id", "BookId", "CategoryId" },
                values: new object[,]
                {
                    { 1L, 1L, 1L },
                    { 2L, 2L, 1L },
                    { 3L, 3L, 1L },
                    { 4L, 4L, 1L },
                    { 5L, 5L, 1L },
                    { 6L, 6L, 1L },
                    { 7L, 7L, 1L },
                    { 8L, 8L, 1L },
                    { 9L, 9L, 1L },
                    { 10L, 10L, 1L },
                    { 11L, 11L, 1L },
                    { 12L, 12L, 1L },
                    { 13L, 13L, 1L },
                    { 14L, 14L, 1L },
                    { 15L, 15L, 1L },
                    { 16L, 16L, 2L },
                    { 17L, 17L, 2L },
                    { 18L, 18L, 2L },
                    { 19L, 19L, 2L },
                    { 20L, 20L, 2L },
                    { 21L, 21L, 2L },
                    { 22L, 22L, 2L },
                    { 23L, 23L, 2L },
                    { 24L, 24L, 2L },
                    { 25L, 25L, 2L },
                    { 26L, 26L, 2L },
                    { 27L, 27L, 2L },
                    { 28L, 28L, 3L },
                    { 29L, 29L, 3L },
                    { 30L, 30L, 3L },
                    { 31L, 31L, 3L },
                    { 32L, 32L, 3L },
                    { 33L, 33L, 3L },
                    { 34L, 34L, 3L },
                    { 35L, 35L, 3L },
                    { 36L, 36L, 3L },
                    { 37L, 37L, 3L },
                    { 38L, 38L, 4L },
                    { 39L, 39L, 4L },
                    { 40L, 40L, 4L },
                    { 41L, 41L, 4L },
                    { 42L, 42L, 4L },
                    { 43L, 43L, 5L },
                    { 44L, 44L, 5L },
                    { 45L, 45L, 5L },
                    { 46L, 46L, 5L },
                    { 47L, 47L, 5L },
                    { 48L, 48L, 6L },
                    { 49L, 49L, 6L },
                    { 50L, 50L, 6L },
                    { 51L, 51L, 6L },
                    { 52L, 52L, 6L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookCategories_BookId",
                table: "BookCategories",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookCategories_CategoryId",
                table: "BookCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookCategories");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
