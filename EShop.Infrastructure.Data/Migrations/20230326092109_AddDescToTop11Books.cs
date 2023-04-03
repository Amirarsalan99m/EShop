using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDescToTop11Books : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(298), "چهل قاعده عشق که به نام ملت عشق نیز شناخته می‌شود، توسط نویسنده فرانسوی متولد ترکیه «الیف شافاک» نوشته شده است. این رمان که پرفروش‌ترین کتاب تاریخ ترکیه به حساب می‌آید، اثری برگرفته از ارتباط عرفانی بین شمس تبریزی و مولانا است که به صورت دو داستان موازی و در هم تنیده روایت می‌شود. بطن اصلی کتاب حول موضوع عشق و نقش آن در دنیای مدرن امروز نسبت به گذشته می‌نگرد و چنان آن را از غرب به شرق گسترش می‌دهد که به زندگی رنگ و بویی عرفانی و زاییده شده از عشق می‌دهد. اینکه چگونه قطعه سنگی کوچک، برکه‌ای راکد و خاموش را به تلاطم و جنبش وا می‌دارد.", new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(302), "رمان مردی به نام اوه عنوان اولین کتاب فردریک بک من است که به سی زبان دنیا ترجمه شده و به عنوان پرفروش‌ترین کتاب سال سوئد معروف شده است و در ایران نیز با ترجمه الناز فرحناکیان توسط نشر نون به چاپ رسیده است. در ادامه با ما همراه باشید تا با معرفی این کتاب جذاب که از پرفروش‌ترین‌های سایت آمازون در سال 2016 نیز به حساب می آید شما را با دنیای نویسندگی فردریک بک من آشنا کنیم.", new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(305), "قبل از خواندن کتاب وقتی نیچه گریست نوشتهُ اروین یالوم با ترجمه سپیده حبیب چه روشی دارید؟ آیا تحقیقی در مورد داستان آن انجام داده‌اید؟، یا شما فقط بدون هیچ گونه اطلاعات قبلی خواندن کتاب را شروع می‌کنید؟ من شخصاً گزینه دوم را ترجیح می‌دهم. بدون اینکه ایده‌ای از آنچه در مورد این رمان بزرگ داشته باشم، خواندن را شروع کردم. در میانه‌های کتاب با خود گفتم: «پرسش‌ها چه هستند؟ و آیا پاسخ‌هایی به فراخور آن وجود دارد؟ علائم اصلی عجز و ناتوانی فردریش نیچه چیست‌اند؟ و یوزف برویر چگونه می‌تواند به روان نیچه وارد شود؟»", new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(309), "روزی نویسندگان و مورخان در آینده به این دوره از تاریخ نگاه می‌کنند و از رمانی صحبت می‌کنند که همه حتی خردسالان و سالمندان را منقلب کرده است. این رمان بی‌شک «جز از کل» نوشته‌ی «استیو تولز» رمان‌نویس استرالیایی خواهد بود که از اعماق وجود انسان‌ها سخن می‌گوید. «جز از کل» درامی خانوادگی است که ترس، انتظار و زندگی را به شکل متفاوتی معنا می‌کند و به تصویر می‌کشد و هر پاراگراف آن، خود داستانی تأمل‌برانگیز است.", new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(311), "بعضی رمان‌ها خلاف جریان آب شنا می‌کنند و این داستان را بسیار خواندنی‌تر و جذاب‌تر می‌کند. کمدی سیاه یک ژانر معروف در ادبیات است که با بیان واقعیات جامعه به زبان طنز سعی دارد هم از اتفاقات جامعه بگوید و هم با روایت کمدی لبخند بر روی لب خواننده بیاورد. یکی از معروف‌ترین کتاب‌های کمدی سیاه مغازه‌ی خودکشی به قلم ژان تولی است. شما با خواندن این کتاب به شهری در آینده‌ی دور می‌روید. جایی بی‌نام و نشان که ممکن است با آن احساس نزدیکی کنید. در سال ۲۰۱۲ نیز از این کتاب یک انیمیشن فرانسوی ساخته شد.", new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(314), "کتاب قلعه حیوانات با عنوان اصلی (Animal Farm) نخستین بار در سال 1945 منتشر شد. جورج اورول این کتاب را در طول جنگ جهانی دوم نوشت و در آن از استبداد طبقه‌ی حاکم شوروی انتقاد کرد. پرچمی که اورول در داستان برای مزرعه‌ی حیوانات ترسیم می‌کند شبیه به پرچم شوروی است. این کتاب درواقع نقدی به نظام سرمایه‌داری است.", new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(318), "«آقای دکتر متوجه چیزهایی که گفتم می‌‌شین؟» تنفس! کلمه‌ای که هم دم و هم بازدم دارد. اگر انسان چنین کلمه‌ای را از دست بدهد همه‌چیز را از دست داده است. «آقای دکتر...» «متوجه می‌شم؟ معلومه! اون‌قدرها هم پرت نشده‌م؛ هنوز نه. به‌نظر می‌آد هنوز می‌تونم ساختارهای سادۀ جملات رو رمزگشایی کنم.» حس می‌کرد صدایش در حال خارج‌شدن از کنترل است و به‌سختی توانست مهارش کند. «حالتون خوبه؟» نبض خودش را حس می‌کرد. به‌نظر عادی می‌آمد اما کاملاً مطمئن نبود. «می‌شه گوشی طبی‌تون رو قرض بگیرم؟»", new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(321), "«این دره نفس می‌کشه و زنده‌ست!» پاپا دستش را به سمت کوه‌هایی بلند کرد که از دور مراقبشان بودند و گفت: «انگورهایی رو بهمون می‌ده که ازمون استقبال می‌کنن.» پدر، به‌آرامی، پیچکی وحشی را نوازش کرد که از روی داربست به پایین خم شده بود و انگار منتظر بود با او دست بدهد. مشتی خاک برداشت و کف دستش وارسی کرد و گفت: «می‌دونستی که وقتی روی زمین دراز بکشی، می‌تونی نفس کشیدن و تپیدن قلبش رو حس کنی؟»", new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(324), "معلم عزیزم، هر زمان می‌خواستم چیزی به تو بگویم، گوشه‌ی لباست را می‌کشیدم و در گوشت زمزمه می‌کردم؛ این بار می‌خواهم نامه‌ای برایت بنویسم...! دخترکی که حالا بزرگ شده برای معلمش نامه‌ای می‌نویسد و خاطرات دوران مدرسه‌ و مهربانی‌های معلمش را تعریف می‌کند. او به یاد معلمش افتاده و تصمیم گرفته برای او نامه‌ای بنویسد. حالا دخترک خودش هم یک معلم است. این کتاب، داستانی احساسی و روایتی زیبا و خواندنی از تلاش‌ها و مهربانی‌های معلمان است. همچنین بر این نکته تمرکز می‌کند که باید قدردان زحمات معلم‌ها باشیم.", new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(326), "دیروز بود که اتاقم را جدا کردند، آیا همان‌طوری که ناظم وعده داد من حالا به‌کلی معالجه شده‌ام و هفته‌ی دیگر آزاد خواهم شد؟ آیا ناخوش بوده‌ام؟ یکسال است، در تمام این مدت هرچه التماس می‌کردم کاغذ و قلم می‌خواستم بهم نمی‌دادند. همیشه پیش خودم گمان می‌کردم هر ساعتی که قلم و کاغذ بدستم بیفتد چقدر چیزها که نخواهم نوشت… ولی دیروز بدون اینکه خواسته باشم کاغذ و قلم را برایم آوردند. چیزی که آنقدر آرزو می‌کردم، چیزی که انتظارش را داشتم ...! اما چه فایده ... از دیروز تا حالا هرچه فکر می‌کنم چیزی ندارم که بنویسم. مثل این است که کسی دست مرا می‌گیرد یا بازویم بی‌حس می‌شود. حالا که دقت می‌کنم مابین خط‌های درهم و برهمی که روی کاغذ کشیده‌ام تنها چیزی که خوانده می‌شود این است: «سه قطره خون»", new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(329), "همسرم در همین اتاق رسیدگی حضور دارد. قبل از اینکه وارد شویم و از بخش حراست عبور کنیم، روی پله‌های بیرون دادگاه همدیگر را در آغوش کشیدیم. سپس با دستان لرزانش دستانم را فشرد و گفت کاری از دست ما ساخته نیست و رأی نهایی را شخص دیگری صادر می‌کند. هر دوی ما می‌دانیم که این اصلاً عادلانه نیست. با شنیدن صدای بلندگو ته دلم خالی می‌شود. مرا صدا می‌کنند. باید بروم داخل. به‌سختی از جایم بلند می‌شوم. مأمور در را برایم باز می‌کند. سرش را به نشانۀ تأیید تکان می‌دهد. چهرۀ بی‌تفاوتی دارد، هرچند اینجا جای فکر کردن به این مسائل نیست. اتاق شمارۀ ۲ خیلی بزرگ‌تر از انتظارم است. همسرم با ظاهری کاملاً خسته و گونه‌هایی خیس بین حضار دیده می‌", new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(332), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(335), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(337), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(340), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(344), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(345) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(347), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(348) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(350), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(352), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(353) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(355), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(358), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(361), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(363), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(366), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(370), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(373), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(375), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(378), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(381), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(382) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(384), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(386), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(389), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(392), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(395), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(398), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(401), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(404), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(406), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(409), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(412), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(414), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(417), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(421), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(424), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(426), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(429), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(432), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(435), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(460), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(463), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(466), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(468), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9008), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9040), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9043), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9045), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9047), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9050), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9931), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9936), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9939), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9942), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9944), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9947), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9949), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9952), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9954), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9956), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9959), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9961), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9964), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9967), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9969), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9972), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9973) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9974), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9976), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9977) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9979), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9981), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9984), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9986), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9989), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9991), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9993), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9996), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9998), new DateTime(2023, 3, 26, 13, 51, 9, 185, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(1), new DateTime(2023, 3, 26, 13, 51, 9, 186, DateTimeKind.Local).AddTicks(2) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9245), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9249), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9252), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9255), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9256) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9258), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9261), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9264), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9265) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9289), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9291), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9294), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9295) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "Description", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9297), "Description", new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9298) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9300), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9301) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9302), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9303) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9305), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9306) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9308), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9311), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9314), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9316), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9317) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9319), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9323), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9326), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9327) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9329), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9331), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9334), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9337), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9340), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9342), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9345), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9349), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9352), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9354), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9357), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9360), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9363), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9365), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9368), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9371), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9375), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9377), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9380), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9383), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9385), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9388), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9391), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9394), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9396), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9400), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9403), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9405), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9406) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9408), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9409) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9411), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9414), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8204), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8229), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8231), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8234), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8236), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8237) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8238), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8239) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8892), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8897), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8902), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8906), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8945), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8949), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8952), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8954), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8957), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8959), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8961), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8964), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8966), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8969), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8971), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8974), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8976), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8978), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8981), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8983), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8984) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8986), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8988), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8990), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8993), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8995), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8998), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9000), new DateTime(2023, 3, 25, 12, 5, 42, 152, DateTimeKind.Local).AddTicks(9001) });
        }
    }
}
