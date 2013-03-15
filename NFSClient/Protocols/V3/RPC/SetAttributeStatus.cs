/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using NFSLibrary.Protocols.Commons;
using org.acplt.oncrpc;

namespace NFSLibrary.Protocols.V3.RPC
{
    public class SetAttributeAccessOK : XdrAble
    {
        private WritingData _dir_wcc;

        public SetAttributeAccessOK()
        { }

        public SetAttributeAccessOK(XdrDecodingStream xdr)
        { xdrDecode(xdr); }

        public void xdrEncode(XdrEncodingStream xdr)
        { this._dir_wcc.xdrEncode(xdr); }

        public void xdrDecode(XdrDecodingStream xdr)
        { this._dir_wcc = new WritingData(xdr); }

        public WritingData Data
        {
            get
            { return this._dir_wcc; }
        }
    }

    public class SetAttributeAccessFAIL : XdrAble
    {
        private WritingData _dir_wcc;

        public SetAttributeAccessFAIL()
        { }

        public SetAttributeAccessFAIL(XdrDecodingStream xdr)
        { xdrDecode(xdr); }

        public void xdrEncode(XdrEncodingStream xdr)
        { this._dir_wcc.xdrEncode(xdr); }

        public void xdrDecode(XdrDecodingStream xdr)
        { this._dir_wcc = new WritingData(xdr); }

        public WritingData Data
        {
            get
            { return this._dir_wcc; }
        }
    }
    // End of RMDIR3res.cs
}