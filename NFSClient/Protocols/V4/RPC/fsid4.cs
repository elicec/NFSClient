/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC
{
    using org.acplt.oncrpc;

    public class fsid4 : XdrAble
    {
        public int major;
        public int minor;

        public fsid4()
        {
        }

        public fsid4(XdrDecodingStream xdr)
        {
            xdrDecode(xdr);
        }

        public void xdrEncode(XdrEncodingStream xdr)
        {
            xdr.xdrEncodeInt(minor);
        }

        public void xdrDecode(XdrDecodingStream xdr)
        {
            minor = xdr.xdrDecodeInt();
        }

    }
}
// End of fsid4.cs
