using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App15
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SclassPage : TabbedPage
	{
		public SclassPage ()
		{
            
            InitializeComponent();
            //_______________________________________________

            if(MainPage.lang == "eng")
            {
                label0.Title = "Info";
                label1.Text = "       Feel intelligent drive";
                label2.Text = "Discover impressive qualities.";
                label3.Text = "The S-Class sedan blurs the line between work and leisure like no other. Materials, atmosphere and quality of interior decoration meet the numerous requirements for a luxury car.The S - Class at the genetic level has the desire to demonstrate new technologies that no other car was equipped with before.";
                label4.Text = "Driving comfort";
                label5.Text = "at the highest level.";
                label6.Text = "S-Class sedan even more accurately and prudently analyzes your surroundings.It can respond even faster and thereby initially reduce even more dangers. But above all, it unloads the driver and other passengers like never before.";
                label7.Title = "Configuration";
                label8.Text = "Choose wheels:";
                label9.Text = "Choose color:";
                picker.Title = "Available Versions:";
            }
            else if (MainPage.lang == "rus")
            {
                label0.Title = "Информация";
                label1.Text = "Почуствуйте великолепное вождение";
                label2.Text = "Откройте для себя впечатляющие качества.";
                label3.Text = "Седан S-класса стирает грань между работой и отдыхом, как никто другой. Материалы, атмосфера и качество внутренней отделки отвечают многочисленным требованиям, предъявляемым к роскошному автомобилю. S-Class на генетическом уровне стремится продемонстрировать новые технологии, которыми раньше не оснащался ни один другой автомобиль.";
                label4.Text = "Комфорт вождения";
                label5.Text = "на высочайшем уровне.";
                label6.Text = "Седан S-класса еще точнее и разумнее анализирует ваше окружение. Он может реагировать еще быстрее и, тем самым, изначально снизить еще больше опасностей. Но, прежде всего, он разгружает водителя и других пассажиров, как никогда раньше.";
                label7.Title = "Конфигурация";
                label8.Text = "Выберите колеса:";
                label9.Text = "Выберите цвет:";
                picker.Title = "Доступные версии:";
            }

            //_______________________________________________

        }

        private int color = 3;
        private int wheels = 1;

        private void Color1_Clicked(object sender, EventArgs e)
        {
            color = 1;
            if(wheels == 1)
            {
                sclassconfig.Source = "sclassconfig11.jpg";
            }
            if (wheels == 2)
            {
                sclassconfig.Source = "sclassconfig21.jpg";
            }
            if (wheels == 3)
            {
                sclassconfig.Source = "sclassconfig31.jpg";
            }

        }

        private void Color2_Clicked(object sender, EventArgs e)
        {
            color = 2;
            if (wheels == 1)
            {
                sclassconfig.Source = "sclassconfig12.jpg";
            }
            if (wheels == 2)
            {
                sclassconfig.Source = "sclassconfig22.jpg";
            }
            if (wheels == 3)
            {
                sclassconfig.Source = "sclassconfig32.jpg";
            }
        }

        private void Color3_Clicked(object sender, EventArgs e)
        {
            color = 3;
            if (wheels == 1)
            {
                sclassconfig.Source = "sclassconfig13.jpg";
            }
            if (wheels == 2)
            {
                sclassconfig.Source = "sclassconfig23.jpg";
            }
            if (wheels == 3)
            {
                sclassconfig.Source = "sclassconfig33.jpg";
            }
        }

        private void Wheel1_Clicked(object sender, EventArgs e)
        {
            wheels = 1;
            if (color == 1)
            {
                sclassconfig.Source = "sclassconfig11.jpg";
            }
            if (color == 2)
            {
                sclassconfig.Source = "sclassconfig12.jpg";
            }
            if (color == 3)
            {
                sclassconfig.Source = "sclassconfig13.jpg";
            }
        }

        private void Wheel2_Clicked(object sender, EventArgs e)
        {
            wheels = 2;
            if (color == 1)
            {
                sclassconfig.Source = "sclassconfig21.jpg";
            }
            if (color == 2)
            {
                sclassconfig.Source = "sclassconfig22.jpg";
            }
            if (color == 3)
            {
                sclassconfig.Source = "sclassconfig23.jpg";
            }
        }

        private void Wheel3_Clicked(object sender, EventArgs e)
        {
            wheels = 3;
            if (color == 1)
            {
                sclassconfig.Source = "sclassconfig31.jpg";
            }
            if (color == 2)
            {
                sclassconfig.Source = "sclassconfig32.jpg";
            }
            if (color == 3)
            {
                sclassconfig.Source = "sclassconfig33.jpg";
            }
        }
        private bool started = false;
        private void Start_Clicked(object sender, EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            if (started == false)
            {      
                started = true;
                player.Load("sclassstart.m4a");
                player.Play();
            }
            else
            {
                started = false;
                player.Stop();
            }
        }

        private bool started1 = false;
        private void Launch_Clicked(object sender, EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            if (started1 == false)
            {
                started1 = true;
                player.Load("sclasslaunch1.m4a");
                player.Play();
            }
            else
            {
                started1 = false;
                player.Stop();
            }
        }

        private void Picker_SelectedItem(object sender, EventArgs e)
        {
            if (Convert.ToString(picker.SelectedItem) == "S350d 4MATIC")
            {
                hp.Text = "HP:  249";
                speed.Text = "0-100:  5.8";
                eng.Text = "Capacity:  2.9";
            }
            else if (Convert.ToString(picker.SelectedItem) == "S400d 4MATIC")
            {
                hp.Text = "HP:  340";
                speed.Text = "0-100:  5.2";
                eng.Text = "Capacity:  2.9";
            }
            else if (Convert.ToString(picker.SelectedItem) == "S450 4MATIC")
            {
                hp.Text = "HP:  367";
                speed.Text = "0-100:  4.9";
                eng.Text = "Capacity:  3.0";
            }
            else if (Convert.ToString(picker.SelectedItem) == "S560 4MATIC")
            {
                hp.Text = "HP:  469";
                speed.Text = "0-100:  4.6";
                eng.Text = "Capacity:  3.9";
            }
            else if (Convert.ToString(picker.SelectedItem) == "S600 4MATIC")
            {
                hp.Text = "HP:  530";
                speed.Text = "0-100:  4.6";
                eng.Text = "Capacity:  6.0";
            }
            else if (Convert.ToString(picker.SelectedItem) == "S63 AMG 4MATIC+")
            {
                hp.Text = "HP:  612";
                speed.Text = "0-100:  3.5";
                eng.Text = "Capacity:  4.0";
            }
        }
    }
}