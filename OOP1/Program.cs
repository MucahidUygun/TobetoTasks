using OOP1.Concrete;
using OOP1.Interface;

internal class Program
{
    private static void Main(string[] args)
    {
        IStutendServices stutendServices = new StutendManager();
        Console.WriteLine("Öğrenci adı:" +stutendServices.GetUserName());
        Console.WriteLine("Öğrenci Doğum Tarihi:" +stutendServices.GetUserBirthDate());
        Console.WriteLine("Öğrenci Çalışıyor Mu ? "+ (stutendServices.GetStutendIsWorking() ? "Evet" : "Hayır") );
        Console.WriteLine("Öğrenci Ortalaması:"+stutendServices.GetStutendAverage().ToString());


        IEducatorServices educatorServices = new EducatorManager();

        Console.WriteLine("Eğitmenin adı:" + educatorServices.GetUserName());
        Console.WriteLine("Eğitmenin Doğum Tarihi:" + educatorServices.GetUserBirthDate());
        Console.WriteLine("Eğitmenin Eğitim Geçmişi:" + educatorServices.GetEducationBackground());
        Console.WriteLine("Eğitmenin Şuan Çalıştığı Firma:" + educatorServices.GetEducatorInWork());

    }
}
