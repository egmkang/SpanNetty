﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DotNetty.Codecs.Http.Tests.WebSockets
{
    using System;
    using DotNetty.Codecs.Http.WebSockets;
    using DotNetty.Common.Utilities;

    public class WebSocketClientHandshaker07Test : WebSocketClientHandshakerTest
    {
        protected override WebSocketClientHandshaker NewHandshaker(Uri uri, string subprotocol, HttpHeaders headers, bool absoluteUpgradeUrl) =>
            new WebSocketClientHandshaker07(uri, WebSocketVersion.V07, subprotocol, false, headers, 1024, true, false, 10000, absoluteUpgradeUrl);

        protected override AsciiString GetOriginHeaderName() => HttpHeaderNames.SecWebsocketOrigin;

        protected override AsciiString GetProtocolHeaderName()
        {
            return HttpHeaderNames.SecWebsocketProtocol;

        }

        protected override AsciiString[] GetHandshakeRequiredHeaderNames()
        {
            return new AsciiString[] {
                HttpHeaderNames.Upgrade,
                HttpHeaderNames.Connection,
                HttpHeaderNames.SecWebsocketKey,
                HttpHeaderNames.Host,
                HttpHeaderNames.SecWebsocketVersion,
            };
        }
    }
}
