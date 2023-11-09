namespace ToDoListApp;

public partial class AgregarTareas : ContentPage
{
    public Tasks NuevaTarea { get; set; }
    public AgregarTareas()
	{
		InitializeComponent();
        NuevaTarea = new Tasks();
        BindingContext = this;
    }

    private void ConfirmarBtn_Clicked(object sender, EventArgs e)
    {
        //metodo con binding
        MessagingCenter.Send(this, "AgregarTarea", NuevaTarea);
        Navigation.PopAsync();

        
    }
    //metodo sin binding 
    /*string taskName = TaskNameEntry.Text;
    string status = StatusEntry.Text;
    // se envian los datos 

    MessagingCenter.Send(this, "AgregarTarea", new Tasks
    {
        TaskName = taskName,
        Status = status
    });

    // Cerrar la página actual
    Navigation.PopAsync();*/
}