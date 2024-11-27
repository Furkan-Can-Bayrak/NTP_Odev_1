using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_4_3
{

    // Çalışan rolleri için enum
    enum EmployeeRole
    {
        Manager,
        Developer,
        Designer,
        Tester
    }

    // Maaş hesaplama işlemi yapan sınıf
    class SalaryCalculator
    {
        // Çalışan rolüne göre maaş hesaplayan metot
        public decimal CalculateSalary(EmployeeRole role)
        {
            switch (role)
            {
                case EmployeeRole.Manager:
                    return 8000m; // Manager maaşı
                case EmployeeRole.Developer:
                    return 6000m; // Developer maaşı
                case EmployeeRole.Designer:
                    return 5000m; // Designer maaşı
                case EmployeeRole.Tester:
                    return 4000m; // Tester maaşı
                default:
                    return 0m; // Geçersiz bir rol
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
