
    namespace Comprobantes
    {

    public class ComprobanteFACNCND
    {
        protected ComprobanteEmisor _emisor = new ComprobanteEmisor();
        protected ComprobanteID _id = new ComprobanteID();
        public ComprobanteEmisor Emisor
        {
            get { return _emisor; }
        }
        public ComprobanteID ID
        {
            get { return _id; }
        }

    }

}




