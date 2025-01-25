using HospitalAppoinmentSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HospitalAppoinmentSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                var services = new ServiceCollection();

                services.AddDbContext<HospitalDbContext>(options =>
                    options.UseSqlServer(DatabaseConfig.ConnectionString,
                        sqlServerOptions => sqlServerOptions.EnableRetryOnFailure(
                            maxRetryCount: 5,
                            maxRetryDelay: TimeSpan.FromSeconds(30),
                            errorNumbersToAdd: null)));

                services.AddTransient<LoginForm>();
                services.AddTransient<DoctorForm>();
                services.AddTransient<ManagerForm>();
                services.AddTransient<PatientForm>();

                using (var serviceProvider = services.BuildServiceProvider())
                {
                    var dbContext = serviceProvider.GetRequiredService<HospitalDbContext>();
                    if (!dbContext.Database.CanConnect())
                    {
                        MessageBox.Show(
                            "Veritabaný baðlantýsý kurulamadý. Lütfen baðlantý ayarlarýný kontrol edin.",
                            "Baðlantý Hatasý",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    Application.Run(new LoginForm(dbContext));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Uygulama baþlatýlýrken bir hata oluþtu:\n{ex.Message}",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}