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
    public class P154_UnknownMessage : GenericMessage
    {
        public Vector2[] Unknown0;
        public int Unknown1;
        
        public override ushort Header
        {
            get
            {
                return 154;
            }
        }
        
        public override void Serialize(Serializer serializer)
        {
            base.Serialize(serializer);
            serializer.Write((byte)Unknown0.Length);
            for (int i = 0; i < Unknown0.Length; i++)
            {
                serializer.WriteVector2(Unknown0[i]);
            }
            serializer.WriteVarint(this.Unknown1);
        }
    }
}
