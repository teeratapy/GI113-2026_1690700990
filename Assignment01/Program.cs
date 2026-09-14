/*
* Student ID :1690700990
* Name       :teeratap_yote
* Section    :129A
* No.        :34
* Course     : GI113 Computer Programming (GI)
*/

using System;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. const (PascalCase) — ค่าคงที่ที่ไม่เปลี่ยนตลอดโปรแกรม
            const string GameTitle = "Neverness to Everness";
            const string CityLocation = "Hethereau Metropolis";

            // 2. var — ใช้อย่างน้อย 2 ตัว (มี string และ char)
            var esperName = "Nanally";           // var บน string
            var esperClass = 'S';                 // var บน char

            // 3. ชนิดข้อมูลพื้นฐานครบ 6 ชนิดแบบมีความหมายตามธีม NTE
            // string : esperName (ประกาศผ่าน var)
            // char   : esperClass (ประกาศผ่าน var)
            int hunterLevel = 50;                 // int
            float criticalRate = 0.45f;           // float
            double anomalySyncRate = 97.6;        // double (เลขหลังจุด >= .5 เพื่อทดสอบการแปลงชนิด)
            bool isLicenseApproved = false;       // bool (อ้างอิงเนื้อเรื่อง: เป็น Unlicensed Hunter)

            // 4. Output: แสดง Stat Card ในรูปแบบสไตล์เกม Sci-Fi / Urban
            Console.WriteLine("==============================================");
            Console.WriteLine($"       <<< {GameTitle} >>>");
            Console.WriteLine($"       Location: {CityLocation}");
            Console.WriteLine("==============================================");
            Console.WriteLine($" Esper Agent  : {esperName}");
            Console.WriteLine($" Rank Class   : Grade [{esperClass}]");
            Console.WriteLine($" Level        : Lv. {hunterLevel}");
            Console.WriteLine($" Crit Rate    : {criticalRate}");
            Console.WriteLine($" Sync Rate    : {anomalySyncRate}%");
            Console.WriteLine($" BAC License  : Approved ({isLicenseApproved})");
            Console.WriteLine("==============================================");
            Console.WriteLine();

            // 5. Implicit Conversion (int -> double) โดยไม่มี Cast
            double levelAsDouble = hunterLevel;
            Console.WriteLine($"[System Log] Level as double (implicit) : {levelAsDouble}");

            // 6. Explicit Cast vs Convert.ToInt32() บนค่า 97.6 ตัวเดียวกัน
            int syncTruncated = (int)anomalySyncRate;               // Explicit Cast -> ตัดเศษทิ้งได้ 97
            int syncRounded = Convert.ToInt32(anomalySyncRate);      // Convert -> ปัดเศษขึ้นได้ 98

            Console.WriteLine($"[System Log] Sync Rate (int cast)       : {syncTruncated}");
            Console.WriteLine($"[System Log] Sync Rate (Convert.ToInt)  : {syncRounded}");
            Console.WriteLine("==============================================");
        }
    }
}