using ComponentsIntergrationMiddleware.api.master.model;
using ComponentsIntergrationMiddleware.api.security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware
{
    public sealed class ComponentIntegrationFacade
    {
        private static ComponentIntegrationFacade instance = new ComponentIntegrationFacade();
        private SecureUser user;
        private SecureRole role;
        private SecurePermissions permissions;
        private SecureDocument document;

        private ComponentIntegrationFacade()
        {
            user = new SecureUser();
            role = new SecureRole(user);
            permissions = new SecurePermissions(user);
            document = new SecureDocument(user);
        }

        public static ComponentIntegrationFacade INSTANCE
        {
            get { return instance; }
        }

        public SecureUser SafeUser
        {
            get { return user; }
        }

        public SecureRole SafeRole
        {
            get { return role; }
        }

        public SecurePermissions SafePermissions
        {
            get { return permissions; }
        }

        public SecureDocument SafeDocument
        {
            get { return document; }
        }

    }
}
