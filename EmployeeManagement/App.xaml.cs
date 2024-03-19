﻿using EmployeeManagement.Interfaces;
using EmployeeManagement.Models;
using EmployeeManagement.Views;
using System.Windows;
using Unity;

namespace EmployeeManagement
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            IUnityContainer unityContainer = new UnityContainer();

            unityContainer.RegisterType<IEmployeeRepository, EmployeeRepository>();
            unityContainer.RegisterType<IEmployeesViewModel, IEmployeesViewModel>();

            unityContainer.Resolve<EmployeesView>().Show();
        }
    }
}
