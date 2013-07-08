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
    public class P445_UnknownMessage : GenericMessage
    {
        public int Unknown0;
        public byte Unknown1;
        public Vector3 Unknown2;
        public float Unknown3;
        
        public override ushort Header
        {
            get
            {
                return 445;
            }
        }
        
        public override void Serialize(Serializer serializer)
        {
            base.Serialize(serializer);
            serializer.WriteVarint(this.Unknown0);
            serializer.Write(this.Unknown1);
            serializer.WriteVector3(this.Unknown2);
            serializer.Write(this.Unknown3);
        }
    }
}
