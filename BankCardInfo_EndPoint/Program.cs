using Microsoft.Extensions.DependencyInjection;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.Design.Behavior;
using ApplicationBankCardInfo.DataBase;
using ApplicationBankCardInfo.Services.AddNewBankCardInfo;
using ApplicationBankCardInfo.Services.DeleteBankCardInfo;
using ApplicationBankCardInfo.Services.GetListBankCard;
using UI_winForm.Forms;
using PersistenceBankCardInfo.Context;

namespace BankCardInfo_EndPoint
{
    internal static class Program
    {
        public  static IServiceProvider ServiceProvider { get; set; }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<IDataBaseContext, DatabaseContext>();
            services.AddScoped<IAddNewBankCardInfoService, AddNewBankCardInfoService>();
            services.AddScoped<IGetListBankCardService, GetListBankCardService>();
            services.AddTransient<IDeleteBankCardInfoService, DeleteBankCardInfoService>();
            services.AddScoped<DatabaseContext>();
            ServiceProvider = services.BuildServiceProvider();
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
          ConfigureServices();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var serviceGetList = (IGetListBankCardService)ServiceProvider.GetService(typeof(IGetListBankCardService));
            var serviceDelete = (IDeleteBankCardInfoService)ServiceProvider.GetService(typeof(IDeleteBankCardInfoService));
            Application.Run(new frmMain(serviceGetList,serviceDelete));
        }
    }
}