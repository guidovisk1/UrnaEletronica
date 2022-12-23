using UrnaEletronica.AppServices.Interfaces;
using UrnaEletronica.AppServices.ViewModel;

namespace UrnaEletronica
{
    public partial class Form1 : Form
    {
        private readonly ICandidatoService _candidatoServices;
        private IList<CandidatoViewModel> _lstCandidatos;
        private CandidatoViewModel? _candidatoAtual;

        public Form1(ICandidatoService candidatoServices)
        {
            InitializeComponent();

            _candidatoServices = candidatoServices;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            _lstCandidatos = (List<CandidatoViewModel>)await _candidatoServices.GetAllAsync();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            // Salvar no .txt
        }

        private void btnNumeroUm_Click(object sender, EventArgs e)
        {
            DigitarVoto(1);
        }

        private void btnNumeroTres_Click(object sender, EventArgs e)
        {
            DigitarVoto(3);
        }

        private void DigitarVoto(int numeroVoto)
        {
            txtNumVoto.Text += numeroVoto.ToString();
        }

        private void txtNumVoto_TextChanged(object sender, EventArgs e)
        {
            if (txtNumVoto.TextLength == 2)
                _candidatoAtual = _lstCandidatos.FirstOrDefault(c => c.NumeroVoto == txtNumVoto.Text);
        }

        private void MostrarCandidato(CandidatoViewModel candidato)
        {
            if (_candidatoAtual is not null) ;

        }
    }
}