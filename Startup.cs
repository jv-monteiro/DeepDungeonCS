﻿using DeepDungeon.Context;
using DeepDungeon.Models;
using DeepDungeon.Repositorios;
using DeepDungeon.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace DeepDungeon
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
                );
            services.AddTransient<IProdutoRepository, ProdutoRepository>();
            services.AddTransient<ICategoriaRepository, CategoriaRepository>();

            services.AddScoped(sp => CarrinhoCompra.GetCarrinho(sp));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            

            services.AddControllersWithViews();

            //Session e Cache da aplicaçao
            services.AddMemoryCache();
            services.AddSession();  //=> Deve ser invocado abaixo do app.UseRouting usando App.UseSession
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "categoriaFiltro",
                    pattern: "Produto/{action}/{categoria?}",
                    defaults: new { controller = "Produto", action = "List" });


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                
            });
        }
    }
}
