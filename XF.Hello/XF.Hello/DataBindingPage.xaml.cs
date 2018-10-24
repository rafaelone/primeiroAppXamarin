using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Hello.App_Code;

namespace XF.Hello
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DataBindingPage : ContentPage
	{
		public DataBindingPage ()
		{
            Aluno aluno = InitializarAluno();
            Professor professor = InitializarProfessor();
       


          //  panelAluno.BindingContext = aluno;

            InitializeComponent ();
            panelAluno.BindingContext = aluno;
            panelProfessor.BindingContext = professor;
        }

        private static Aluno InitializarAluno()
        {
            return new Aluno()
            {

                Id = Guid.NewGuid(),
                Nome = "Rafael",
                Email = "rafael@live.com"
            };
        }
        
        private static Professor InitializarProfessor()
        {
            return new Professor()
            {
                Nome = "Maria",
                Curso = "Xamarin"
            };
        }

    }
}