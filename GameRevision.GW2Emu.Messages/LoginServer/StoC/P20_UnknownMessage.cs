/*
 * This code was autogenerated by
 * GameRevision.GW2Emu.CodeWriter.
 * Date generated: 08-07-13
 */

using System;
using System.IO;
using System.Net;
using GameRevision.GW2Emu.Core;
using GameRevision.GW2Emu.Core.Types;
using GameRevision.GW2Emu.Core.Serializers;

namespace GameRevision.GW2Emu.Messages.LoginServer.StoC
{
    public class P20_UnknownMessage : GenericMessage
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;
        public IPEndPoint Unknown4;
        public int Unknown5;
        
        public override ushort Header
        {
            get
            {
                return 20;
            }
        }
        
        public override void Serialize(Serializer serializer)
        {
            base.Serialize(serializer);
            serializer.WriteVarint(this.Unknown0);
            serializer.WriteVarint(this.Unknown1);
            serializer.WriteVarint(this.Unknown2);
            serializer.WriteVarint(this.Unknown3);
            serializer.WriteIPEndPoint(this.Unknown4);
            serializer.WriteVarint(this.Unknown5);
        }
    }
}
