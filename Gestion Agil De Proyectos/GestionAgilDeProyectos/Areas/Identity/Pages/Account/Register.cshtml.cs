using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GestionAgilDeProyectos.Data;

namespace GestionAgilDeProyectos.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

		public RegisterModel(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
		}

		[BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
			[Required(ErrorMessage = "Debes Ingresar tu Correo")]
			[EmailAddress]
            [Display(Name = "Correo")]
            public string Email { get; set; }

			[Required(ErrorMessage = "Debes crear tu contraseña")]
			[StringLength(100, ErrorMessage = "La {0} debe tener al menos {2} y un máximo de {1} caracteres de longitud.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Contraseña")]
            public string Password { get; set; }

			[Required(ErrorMessage = "Debes Confirmar Contraseña")]
			[DataType(DataType.Password)]
            [Display(Name = "Confirmar Contraseña")]
            [Compare("Password", ErrorMessage = "La nueva contraseña y la contraseña de confirmación no coinciden.")]
            public string ConfirmPassword { get; set; }

			[Required(ErrorMessage = "Debes Ingresar tu Telefono")]
			[Phone]
            [Display(Name = "Telefono")]
            public string PhoneNumber { get; set; }

			[Required(ErrorMessage = "Debes Ingresar tu Nombre")]
			[Display(Name = "Nombre")]
			public string Nombre { get; set; }

			[Required(ErrorMessage = "Debes Ingresar tus Apellidos")]
			[Display(Name = "Apellidos")]
			public string Apellido { get; set; }

			[Required(ErrorMessage = "Debes Ingresar tu RUT")]
			[RegularExpression(@"^[0-9kK''-'\s]{1,40}$", ErrorMessage = "RUT Ingresado no es valido")]
			[Display(Name = "RUT")]
			[MaxLength(9)]
			public string Rut { get; set; }

			[Required(ErrorMessage = "Debes Ingresar tu Fecha de Nacimiento")]
			[Display(Name = "Fecha de Nacimiento")]
			[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
			public string FechaNacimiento { get; set; }

            [Required(ErrorMessage = "Debes Aceptar los Términos y Condiciones")]
            [Display(Name = "Términos y Condiciones")]
            public bool Terms { get; set; }

        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = Input.Email, Email = Input.Email, PhoneNumber = Input.PhoneNumber, EmailConfirmed = true, PhoneNumberConfirmed = true, Nombre = Input.Nombre, 
                    Apellido = Input.Apellido, Rut = Input.Rut, FechaNacimiento = Input.FechaNacimiento, Terms = Input.Terms
				};
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
					return RedirectToPage("Login");
				}
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return Page();
        }
    }
}
