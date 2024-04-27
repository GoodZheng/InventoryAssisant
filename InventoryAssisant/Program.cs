

using InventoryAssisant.DataBase;
using InventoryAssisant.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryAssisant
{
    internal static class Program
    {
        //public static IConfiguration Configuration { get; private set; }

        private static IServiceProvider _serviceProvider;
        public static IServiceProvider ServiceProvider
        {
            get => _serviceProvider;
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Application.Run(new Form1());

            ServiceCollection services = new ServiceCollection(); //����IOC��������
            ConfigureServices(services); //����ע��
            _serviceProvider = services.BuildServiceProvider(); //ʵ����ServiceProvider����

            Application.Run(_serviceProvider.GetRequiredService<MainForm>());
        }


        /// <summary>
        /// ��DI������ע�����з�������
        /// </summary>
        /// <param name="services"></param>
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<MainForm>(); //�����嵥��

            services.AddTransient<RestockForm>(); //�Ӵ�������Ϊ˲ʱ�������ڶ��δ�ʱ�ᱨ��
            services.AddTransient<RemoveForm>();
            services.AddTransient<EditItemsForm>();
            services.AddTransient<CreateItemForm>();
            services.AddTransient<EditCategoriesForm>();

            services.AddDbContext<AppDbContext>();

            services.AddScoped<IInventoryRepository, InventoryRepository>();
        }
    }
}