

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

            ServiceCollection services = new ServiceCollection(); //创建IOC容器对象
            ConfigureServices(services); //服务注册
            _serviceProvider = services.BuildServiceProvider(); //实例化ServiceProvider对象

            Application.Run(_serviceProvider.GetRequiredService<MainForm>());
        }


        /// <summary>
        /// 在DI容器中注册所有服务类型
        /// </summary>
        /// <param name="services"></param>
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<MainForm>(); //主窗体单例

            services.AddTransient<RestockForm>(); //子窗体设置为瞬时，否则在二次打开时会报错
            services.AddTransient<RemoveForm>();
            services.AddTransient<EditItemsForm>();
            services.AddTransient<CreateItemForm>();
            services.AddTransient<EditCategoriesForm>();

            services.AddDbContext<AppDbContext>();

            services.AddScoped<IInventoryRepository, InventoryRepository>();
        }
    }
}