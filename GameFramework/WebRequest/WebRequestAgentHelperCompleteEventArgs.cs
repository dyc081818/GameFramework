//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using System.Collections.Generic;

namespace GameFramework.WebRequest
{
    /// <summary>
    /// Web 请求代理辅助器完成事件。
    /// </summary>
    public sealed class WebRequestAgentHelperCompleteEventArgs : GameFrameworkEventArgs
    {
        private Dictionary<string, string> m_WebResponseHeaders;
        private byte[] m_WebResponseBytes;

        /// <summary>
        /// 初始化 Web 请求代理辅助器完成事件的新实例。
        /// </summary>
        public WebRequestAgentHelperCompleteEventArgs()
        {
            m_WebResponseHeaders = null;
            m_WebResponseBytes = null;
        }

        /// <summary>
        /// 创建 Web 请求代理辅助器完成事件。
        /// </summary>
        /// <param name="headers">相应数据头</param>
        /// <param name="webResponseBytes">Web 响应的数据流。</param>
        /// <returns>创建的 Web 请求代理辅助器完成事件。</returns>
        public static WebRequestAgentHelperCompleteEventArgs Create(Dictionary<string, string> headers, byte[] webResponseBytes)
        {
            WebRequestAgentHelperCompleteEventArgs webRequestAgentHelperCompleteEventArgs = ReferencePool.Acquire<WebRequestAgentHelperCompleteEventArgs>();
            webRequestAgentHelperCompleteEventArgs.m_WebResponseHeaders = headers;
            webRequestAgentHelperCompleteEventArgs.m_WebResponseBytes = webResponseBytes;

            return webRequestAgentHelperCompleteEventArgs;
        }

        /// <summary>
        /// 清理 Web 请求代理辅助器完成事件。
        /// </summary>
        public override void Clear()
        {
            m_WebResponseHeaders = null;
            m_WebResponseBytes = null;
        }

        /// <summary>
        /// 获取web 相应数据头
        /// </summary>
        /// <returns>数据头字典</returns>
        public Dictionary<string, string> GetWebResponseHeaders()
        {
            return m_WebResponseHeaders;
        }

        /// <summary>
        /// 获取 Web 响应的数据流。
        /// </summary>
        /// <returns>Web 响应的数据流。</returns>
        public byte[] GetWebResponseBytes()
        {
            return m_WebResponseBytes;
        }
    }
}
