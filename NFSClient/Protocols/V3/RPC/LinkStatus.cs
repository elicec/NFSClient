/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using NFSLibrary.Protocols.Commons;
using org.acplt.oncrpc;

namespace NFSLibrary.Protocols.V3.RPC
{
    public class LinkAccessOK : XdrAble
    {
        private PostOperationAttributes _file_attributes;
        private WritingData _linkdir_wcc;

        public LinkAccessOK()
        { }

        public LinkAccessOK(XdrDecodingStream xdr)
        { xdrDecode(xdr); }

        public void xdrEncode(XdrEncodingStream xdr)
        {
            this._file_attributes.xdrEncode(xdr);
            this._linkdir_wcc.xdrEncode(xdr);
        }

        public void xdrDecode(XdrDecodingStream xdr)
        {
            this._file_attributes = new PostOperationAttributes(xdr);
            this._linkdir_wcc = new WritingData(xdr);
        }

        public PostOperationAttributes Attributes
        {
            get
            { return this._file_attributes; }
        }

        public WritingData Data
        {
            get
            { return this._linkdir_wcc; }
        }
    }

    public class LinkAccessFAIL : XdrAble
    {
        private PostOperationAttributes _file_attributes;
        private WritingData _linkdir_wcc;

        public LinkAccessFAIL()
        { }

        public LinkAccessFAIL(XdrDecodingStream xdr)
        { xdrDecode(xdr); }

        public void xdrEncode(XdrEncodingStream xdr)
        {
            this._file_attributes.xdrEncode(xdr);
            this._linkdir_wcc.xdrEncode(xdr);
        }

        public void xdrDecode(XdrDecodingStream xdr)
        {
            this._file_attributes = new PostOperationAttributes(xdr);
            this._linkdir_wcc = new WritingData(xdr);
        }

        public PostOperationAttributes Attributes
        {
            get
            { return this._file_attributes; }
        }

        public WritingData Data
        {
            get
            { return this._linkdir_wcc; }
        }
    }
    // End of LINK3res.cs
}