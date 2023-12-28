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
	public partial class TitulPage : ContentPage
	{

		public TitulPage ()
		{
            InitializeComponent ();

            //___________________________________________

            if (MainPage.lang == "eng")
            {
                label1.Text = "Our business divisions.";
                label2.Text = "Mercedes-Benz AG is one of the largest manufacturers of premium passenger cars. In 2018, it sold more than 2.3 million cars and over 420,000 vans.In its two business divisions, Mercedes - Benz AG is continually expanding its worldwide production network with over 40 production sites on four continents, while aligning itself to meet the requirements of electric mobility. At the same time, the company is developing its global battery production network on three continents.Sustainable actions play a decisive role in both business divisions.";
                label3.Text = "To the company, sustainability means creating value for all stakeholders on a lasting basis: customers, employees, investors, business partners and the society as a whole.The basis for this is the sustainable business strategy of Daimler in which the company takes responsibility for the economic, ecological and social effects of its business activities and looks at the entire value chain.";
                label4.Text = "Mercedes-Benz Cars.";
                label5.Text = "The Mercedes-Benz Cars range covers every passenger car segment: from the urban microcar by smart, to the premium and luxury vehicles by Mercedes-Benz and Mercedes-Maybach, to the performance and sports cars by Mercedes-AMG.In this way, the Cars division of Mercedes - Benz AG ensures individual mobility for a vast spectrum of customer needs.The company has set itself the goal of developing the world's safest and most efficient cars. With the technology brand EQ, Mercedes-Benz Cars is driving  forward the systematic development of alternative drives: the aim is to electrify the entire portfolio by 2022.";
                label6.Text = "The company will offer a range of electrified models in each segment, including 48 - volt models, a wide choice of plug -in hybrids, and all-electric vehicles with battery and/ or fuel cell. Mercedes - Benz Cars broke its sales record in 2018, selling 2,382,791 vehicles.Mercedes - Benz recorded the highest unit sales of any premium brand in the automotive industry for the third time in succession.";
                label7.Text = "Ambition 2039: the road to";
                label8.Text = "sustainable mobility.";
                label9.Text = "Under the heading Ambition 2039, Mercedes-Benz Cars has set itself ambitious yet realistic goals. As part of this, the automotive manufacturer is examining the issue of sustainability along the entire value chain. The goal is the transformation of the full range of passenger cars into a carbon-neutral product range as of 2039.This includes topics such as raw materials and the supply chain, the production of the vehicles, their usephase and recycling concepts. Similar transformation plans are being developed for the commercial vehicles. Already during the development of a new model, Mercedes - Benz Cars looks at its environmental performance over the entire life cycle.Vehicles from Mercedes-Benz Cars are scrutinised in a comprehensive life - cycle assessment, the so - called 360 - degree environmental check: from manufacture of the raw materials to production and from vehicle operation to recycling at the end of the vehicle's service life – a long way off in the case of a new Mercedes- Benz.";
            }
            else if(MainPage.lang == "rus")
            {
                label1.Text = "Наши бизнес-подразделения.";
                label2.Text = "Mercedes-Benz AG является одним из крупнейших производителей легковых автомобилей премиум-класса. В 2018 году было продано более 2,3 миллиона автомобилей и более 420 000 фургонов.В двух своих бизнес-подразделениях Mercedes - Benz AG постоянно расширяет свою всемирную производственную сеть: 40 производственных площадок на четырех континентах, при этом адаптируя себя, чтобы соответствовать требованиям электрической мобильности. В то же время компания развивает свою глобальную сеть производства батарей на трех континентах. Уверенные действия играют решающую роль в обоих бизнес-подразделениях.";
                label3.Text = "Для компании устойчивость означает создание ценности для всех заинтересованных сторон на долгосрочной основе: клиентов, сотрудников, инвесторов, деловых партнеров и общества в целом. Основой этого является устойчивая бизнес-стратегия Daimler, в которой компания берет на себя ответственность за экономические, экологические и социальные последствия своей деловой активности и следит за ситуацией создания стоимости.";
                label4.Text = "Автомобили Mercedes-Benz.";
                label5.Text = "Ассортимент автомобилей Mercedes-Benz Cars охватывает все сегменты легковых автомобилей: от городского миниавтомобиля Smart до автомобилей премиум-класса и класса люкс Mercedes-Benz и Mercedes-Maybach, до спортивных и спортивных автомобилей Mercedes-AMG. Таким образом, подразделение «Автомобили» Mercedes-Benz AG обеспечивает индивидуальную мобильность для широкого спектра потребностей клиентов. Компания поставила перед собой цель разработать самые безопасные и эффективные автомобили в мире. С технологическим брендом EQ Mercedes-Benz Cars продвигает систематическое развитие альтернативных двигателей: цель состоит в том, чтобы электрифицировать весь модельный ряд к 2022 году.";
                label6.Text = "Компания предлагает широкий ассортимент электрифицированных моделей в каждом сегменте, в том числе 48-вольтовые модели, широкий выбор гибридов со штепсельной вилкой и полностью электромобили с аккумулятором и / или топливным элементом. Mercedes-Benz побил свой рекорд продаж в 2018 году, продав 2 382 791 автомобиля. Mercedes-Benz в третий раз подряд зафиксировал самые высокие показатели продаж среди всех марок автомобилей премиум-класса в автомобильной промышленности.";
                label7.Text = "Амбиции 2039: дорога к";
                label8.Text = "устойчивой мобильности.";
                label9.Text = "Под маркой Ambition 2039 Mercedes-Benz Cars ставит перед собой амбициозные, но реальные цели. В рамках этого, производитель автомобилей изучает вопрос устойчивости по всей цепочке создания стоимости. Целью является преобразование всего ассортимента легковых автомобилей в ассортимент продукции с нейтральным уровнем выбросов углерода с 2039 года. Это включает такие темы, как сырье и цепочки поставок, производство транспортных средств, концепции их использования и вторичной переработки. Аналогичные планы трансформации разрабатываются для коммерческого транспорта. Уже во время разработки новой модели Mercedes-Benz Cars рассматривает свои экологические характеристики на протяжении всего жизненного цикла. Автомобили Mercedes-Benz тщательно изучаются при всесторонней оценке жизненного цикла, так называемой 360-градусной экологической проверке: от от производства сырья до производства и от эксплуатации автомобиля до переработки в конце срока службы автомобиля - долгий путь в случае нового Mercedes-Benz.";
            }

            //___________________________________________

        }

    }
}