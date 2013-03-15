/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC
{
    using org.acplt.oncrpc;

    public class deleg_claim4 : XdrAble
    {
        public int dc_claim;
        public int dc_delegate_type;

        public deleg_claim4()
        {
        }

        public deleg_claim4(XdrDecodingStream xdr)
        {
            xdrDecode(xdr);
        }

        public void xdrEncode(XdrEncodingStream xdr)
        {
            xdr.xdrEncodeInt(dc_claim);
            switch (dc_claim)
            {
                case open_claim_type4.CLAIM_FH:
                    break;
                case open_claim_type4.CLAIM_DELEG_PREV_FH:
                    break;
                case open_claim_type4.CLAIM_PREVIOUS:
                    xdr.xdrEncodeInt(dc_delegate_type);
                    break;
            }
        }

        public void xdrDecode(XdrDecodingStream xdr)
        {
            dc_claim = xdr.xdrDecodeInt();
            switch (dc_claim)
            {
                case open_claim_type4.CLAIM_FH:
                    break;
                case open_claim_type4.CLAIM_DELEG_PREV_FH:
                    break;
                case open_claim_type4.CLAIM_PREVIOUS:
                    dc_delegate_type = xdr.xdrDecodeInt();
                    break;
            }
        }

    }
}
// End of deleg_claim4.cs
