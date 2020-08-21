# Failover groups

## Requirements
* An Azure account in order to create a database and a fail over group.

## Setup
* Go to `App.config` in the `Main` project and replace the next settings for the correct values:
```
    <add key="FAILOVER_GROUP_NAME" value="Your_failover_group_name" />
    <add key="DB_NAME" value="Your_database_name" />
    <add key="USER_ID" value="Your_database_user_id" />
    <add key="PASSWORD" value="Your_database_password" />
```

* Go to the folder `PostmanCollection` in the `Main` project and  import to Postman the file `Azure REST API.postman_collection`.
* Follow the sections `Azure Setup (AZURE CLI)` and `Postman Setup` in [Auto-failover groups](https://safefleet.atlassian.net/wiki/spaces/CMC/pages/1115357221/Auto-failover+groups) in order to configure the postman variables.

## Usage
* Run the `Main` project.
* Follow the sections `Get AAD Token Request` and `Start failover manually` in [Auto-failover groups](https://safefleet.atlassian.net/wiki/spaces/CMC/pages/1115357221/Auto-failover+groups) document.

## Basic concepts
* A **tenant** is the Azure Active Directory entity that encompasses a whole organization.  This tenant has at least one subscription and user. 
* A **user** is an individual and is associated with only one tenant, the organization that they belong to. Users are those accounts that sign in to Azure to create, manage, and use resources.
* A user may have access to multiple **subscriptions**, which are the agreements with Microsoft to use cloud services, including Azure. Every resource is associated with a subscription
* An **Azure service principal** is an identity created for use with applications, hosted services, and automated tools to access Azure resources. This access is restricted by the roles assigned to the service principal, giving you control over which resources can be accessed and at which level
* **Auto-failover groups** allow you to manage replication and failover of a group of databases on a server or all databases in a managed instance to another region.
* **Failover group read-write listener** is a DNS CNAME record that points to the current primary's URL. It is created automatically when the failover group is created and allows the read-write workload to transparently reconnect to the primary database when the primary changes after failover. 
* **Failover group read-only listener** is a DNS CNAME record formed that points to the read-only listener that points to the secondary's URL. It is created automatically when the failover group is created and allows the read-only SQL workload to transparently connect to the secondary using the specified load-balancing rules.

## Resouces
### Auto-failover groups resource
* [Use auto-failover groups to enable transparent and coordinated failover of multiple databases](https://docs.microsoft.com/en-us/azure/azure-sql/database/auto-failover-group-overview?tabs=azure-powershell)

### Failover groups resources
* [Tutorial: Add an Azure SQL Database to an autofailover group](https://docs.microsoft.com/en-us/azure/azure-sql/database/failover-group-add-single-database-tutorial?tabs=azure-portal)
* [Tutorial: Implement a geo-distributed database (Azure SQL Database)](https://docs.microsoft.com/en-us/azure/azure-sql/database/geo-distributed-application-configure-tutorial?tabs=azure-powershell)

### Azure CLI (Command-line interface)
* [Use multiple Azure subscriptions](https://docs.microsoft.com/en-us/cli/azure/manage-azure-subscriptions-azure-cli?view=azure-cli-latest)
* [Create an Azure service principal with the Azure CLI](https://docs.microsoft.com/en-us/cli/azure/create-an-azure-service-principal-azure-cli?toc=%2Fazure%2Fazure-resource-manager%2Ftoc.json&view=azure-cli-latest)

### Azure REST API resources
* [Azure REST API Reference](https://docs.microsoft.com/en-us/rest/api/azure/)
* [Azure REST APIs with Postman in 2 Minutes](https://blog.jongallant.com/2017/11/azure-rest-apis-postman/)
* [Failover Groups](https://docs.microsoft.com/en-us/rest/api/sql/failovergroups)
* [Azure SQL Database REST API](https://docs.microsoft.com/en-us/rest/api/sql/)
  * [Database](https://docs.microsoft.com/en-us/rest/api/sql/databases)
  * [Servers](https://docs.microsoft.com/en-us/rest/api/sql/servers)

### Management Libraries for .NET
* [Get Started with the Management Libraries for .NET](https://docs.microsoft.com/en-us/previous-versions/azure/dn722415(v=azure.100)?redirectedfrom=MSDN)
