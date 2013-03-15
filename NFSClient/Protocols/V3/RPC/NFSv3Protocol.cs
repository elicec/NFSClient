/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
/**
 * A collection of constants used by the "NFSv3Protocol" ONC/RPC program.
 */
namespace NFSLibrary.Protocols.V3.RPC
{
    public class NFSv3Protocol
    {
        public const int NFS_PROGRAM = 100003;
        public const int NFS_V3 = 3;

        public const int ACCESS3_READ = 0x0001;
        public const int ACCESS3_LOOKUP = 0x0002;
        public const int ACCESS3_MODIFY = 0x0004;
        public const int ACCESS3_EXTEND = 0x0008;
        public const int ACCESS3_DELETE = 0x0010;
        public const int ACCESS3_EXECUTE = 0x0020;

        public const int NFSPROC3_NULL = 0;
        public const int NFSPROC3_GETATTR = 1;
        public const int NFSPROC3_SETATTR = 2;
        public const int NFSPROC3_LOOKUP = 3;
        public const int NFSPROC3_ACCESS = 4;
        public const int NFSPROC3_READLINK = 5;
        public const int NFSPROC3_READ = 6;
        public const int NFSPROC3_WRITE = 7;
        public const int NFSPROC3_CREATE = 8;
        public const int NFSPROC3_MKDIR = 9;
        public const int NFSPROC3_SYMLINK = 10;
        public const int NFSPROC3_MKNOD = 11;
        public const int NFSPROC3_REMOVE = 12;
        public const int NFSPROC3_RMDIR = 13;
        public const int NFSPROC3_RENAME = 14;
        public const int NFSPROC3_LINK = 15;
        public const int NFSPROC3_READDIR = 16;
        public const int NFSPROC3_READDIRPLUS = 17;
        public const int NFSPROC3_FSSTAT = 18;
        public const int NFSPROC3_FSINFO = 19;
        public const int NFSPROC3_PATHCONF = 20;
        public const int NFSPROC3_COMMIT = 21;

        public const int FSF3_LINK = 0x0001;
        public const int FSF3_SYMLINK = 0x0002;
        public const int FSF3_HOMOGENEOUS = 0x0008;
        public const int FSF3_CANSETTIME = 0x0010;

        public const int NFS3_COOKIEVERFSIZE = 8;
        public const int NFS3_WRITEVERFSIZE = 8;
        public const int NFS3_CREATEVERFSIZE = 8;
        public const int NFS3_FHSIZE = 64;
    }
    // End of NFSv3Protocol.cs
}