namespace ToDoListApp;

public partial class AgregarTareas : ContentPage
{
	public AgregarTareas()
	{
		InitializeComponent();
	}

    private void ConfirmarBtn_Clicked(object sender, EventArgs e)
    {
        string taskName = TaskNameEntry.Text;
        string status = StatusEntry.Text;
        // se envian los datos 
        
        MessagingCenter.Send(this, "AgregarTarea", new Tasks
        {
            TaskName = taskName,
            Status = status
        });

        // Cerrar la página actual
        Navigation.PopAsync();
    }
}