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

namespace GameRevision.GW2Emu.Messages.GameServer.StoC
{
    public class P463_UnknownMessage : GenericMessage
    {
        public int Unknown0;
        public byte Unknown1;
        public int Unknown2;
        public WorldPosition Unknown3;
        public float Unknown4;
        public byte Unknown5;
        public long Unknown6;
        public byte Unknown7;
        
        public override ushort Header
        {
            get
            {
                return 463;
            }
        }
        
        public override void Serialize(Serializer serializer)
        {
            base.Serialize(serializer);
            serializer.WriteVarint(this.Unknown0);
            serializer.Write(this.Unknown1);
            serializer.WriteVarint(this.Unknown2);
            serializer.WriteWorldPosition(this.Unknown3);
            serializer.Write(this.Unknown4);
            serializer.Write(this.Unknown5);
            serializer.Write(this.Unknown6);
            serializer.Write(this.Unknown7);
        }
    }
}
