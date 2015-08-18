﻿using Abp.MultiTenancy;

namespace Abp.Runtime.Session
{
    /// <summary>
    /// Implements null object pattern for <see cref="IAbpSession"/>.
    /// </summary>
    public class NullAbpSession : IAbpSession
    {
        /// <summary>
        /// Singleton instance.
        /// </summary>
        public static NullAbpSession Instance { get { return SingletonInstance; } }
        private static readonly NullAbpSession SingletonInstance = new NullAbpSession();

        /// <inheritdoc/>
        public long? UserId { get { return null; } }

        /// <inheritdoc/>
        public int? TenantId { get { return null; } }
        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName { get { return ""; } }

        public MultiTenancySides MultiTenancySide { get { return MultiTenancySides.Tenant; } }

        private NullAbpSession()
        {

        }
    }
}