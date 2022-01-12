
    namespace Comprobantes
    {

    public class ComprobanteFACNCND
    {
        protected BaseEmisor _emisor = new BaseEmisor();
        protected BaseComprobanteID _id = new BaseComprobanteID();
        public BaseEmisor Emisor
        {
            get { return _emisor; }
        }
        public BaseComprobanteID ID
        {
            get { return _id; }
        }

    }

}




