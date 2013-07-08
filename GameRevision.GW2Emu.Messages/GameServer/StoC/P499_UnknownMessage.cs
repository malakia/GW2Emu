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
    public class P499_UnknownMessage : GenericMessage
    {
        public int Unknown0;
        public string Unknown1;
        public int Unknown2;
        public int Unknown3;
        
        public override ushort Header
        {
            get
            {
                return 499;
            }
        }
        
        public override void Serialize(Serializer serializer)
        {
            base.Serialize(serializer);
            serializer.WriteVarint(this.Unknown0);
            serializer.WriteUtf16String(this.Unknown1);
            serializer.WriteVarint(this.Unknown2);
            serializer.WriteVarint(this.Unknown3);
        }
    }
}
