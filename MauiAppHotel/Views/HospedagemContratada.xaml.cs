namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
    public HospedagemContratada(String qtdeAdultosDigitado, String qtdeCriancaDigitado, 
        DateTime dataInicio, DateTime dataFim, String quarto)
	{
		InitializeComponent();
        quartoSelecionado.Text = quarto;
        qtdeAdultos.Text = qtdeAdultosDigitado;
        qtdeCrianca.Text = qtdeCriancaDigitado;
        dataEntrada.Text = dataInicio.ToString("dd/MM/yyyy");
        dataSaida.Text = dataFim.ToString("dd/MM/yyyy");
        
        TimeSpan dias = dataFim - dataInicio;

        qtdeEstadias.Text = dias.Days.ToString();


}



    private void Button_Clicked(object sender, EventArgs e)
    {
    }



}