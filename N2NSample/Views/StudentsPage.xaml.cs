using N2NSample.Helper;
using N2NSample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace N2NSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentsPage : ContentPage
    {
        public ObservableCollection<Student> Students { get; set; }

        public StudentsPage()
        {
            InitializeComponent();
            GetStudents(); 
            BindingContext = this;
        }

        private async void GetStudents()
        {
            var students = await ServiceHelperOnline.Instance.GetStudents();
            Students = new ObservableCollection<Student>(students);
        }


        //void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        //    => ((ListView)sender).SelectedItem = null;

        //async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    if (e.SelectedItem == null)
        //        return;

        //    await DisplayAlert("Selected", e.SelectedItem.ToString(), "OK");

        //    //Deselect Item
        //    ((ListView)sender).SelectedItem = null;
        //}
    }



    class ListViewPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Student> Students { get; set; }
        public ObservableCollection<Grouping<string, Student>> StudentsGrouped { get; set; }

        public ListViewPageViewModel()
        {
            try
            {
                GetStudents();

                //RefreshDataCommand = new Command(
                //    async () => await RefreshData());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void GetStudents()
        {
            var students = await ServiceHelperOnline.Instance.GetStudents();
            Students = new ObservableCollection<Student>(students);
            //var sorted = from item in Students
            //             orderby item.Name
            //             group item by item.Name[0].ToString() into itemGroup
            //             select new Grouping<string, Student>(itemGroup.Key, itemGroup);

            //StudentsGrouped = new ObservableCollection<Grouping<string, Student>>(sorted);
        }

        public ICommand RefreshDataCommand { get; }

        async Task RefreshData()
        {
            IsBusy = true;
            //Load Data Here
            GetStudents(); 

            IsBusy = false;
        }

        bool busy;
        public bool IsBusy
        {
            get { return busy; }
            set
            {
                busy = value;
                OnPropertyChanged();
                ((Command)RefreshDataCommand).ChangeCanExecute();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public class Item
        {
            public string Text { get; set; }
            public string Detail { get; set; }

            public override string ToString() => Text;
        }

        public class Grouping<K, T> : ObservableCollection<T>
        {
            public K Key { get; private set; }

            public Grouping(K key, IEnumerable<T> items)
            {
                Key = key;
                foreach (var item in items)
                    this.Items.Add(item);
            }
        }
    }
}
