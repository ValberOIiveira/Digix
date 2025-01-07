using System.Security.AccessControl;

namespace DesafioEnum
{
    public interface IGerente
    {
        public void autorizar();

        public bool concedeAumento();
        public bool autorizaLincenca();
    }
}