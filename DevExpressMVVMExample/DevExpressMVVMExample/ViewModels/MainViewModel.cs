﻿using DevExpress.Mvvm.CodeGenerators;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace DevExpressMVVMExample.ViewModels
{
    [GenerateViewModel]
    public partial class MainViewModel
    {
        [GenerateProperty]
        int _Count;

        [GenerateProperty]
        [StringLength(100, MinimumLength = 5)]
        string _Text = "12345";

        [GenerateCommand]
        void Increse() => Count++;

        [GenerateCommand]
        void Decrease() => Count--;

        [GenerateCommand]
        void Initialize() => Count = 0;
        bool CanInitialize() => Count > 10;

        [GenerateCommand(AllowMultipleExecution = true)]
        async Task AsyncIncrese()
        {
            await Task.Delay(1000);
            Count++;
        }
    }
}
