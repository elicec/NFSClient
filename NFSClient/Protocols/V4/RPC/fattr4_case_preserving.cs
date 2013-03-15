/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC
{
    using org.acplt.oncrpc;

    public class fattr4_case_preserving : XdrAble
    {

        public bool value;

        public fattr4_case_preserving()
        {
        }

        public fattr4_case_preserving(bool value)
        {
            this.value = value;
        }

        public fattr4_case_preserving(XdrDecodingStream xdr)
        {
            xdrDecode(xdr);
        }

        public void xdrEncode(XdrEncodingStream xdr)
        {
            xdr.xdrEncodeBoolean(value);
        }

        public void xdrDecode(XdrDecodingStream xdr)
        {
            value = xdr.xdrDecodeBoolean();
        }

    }
}
// End of fattr4_case_preserving.cs
