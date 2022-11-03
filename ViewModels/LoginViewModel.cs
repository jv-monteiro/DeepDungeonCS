﻿using System.ComponentModel.DataAnnotations;

namespace DeepDungeon.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Informe o nome de usuário")]
        [Display(Name ="Usuário")]
        public string UserName { get; set; }
        
        [Required(ErrorMessage ="Informe a senha!")]
        [DataType(DataType.Password)]
        [Display(Name ="Senha")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }

    }
}
