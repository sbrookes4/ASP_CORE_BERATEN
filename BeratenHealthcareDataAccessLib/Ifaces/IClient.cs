using BeratenHealthcareModels;
using System.Collections.Generic;

namespace BeratenHealthcareDataInterfaceLib
{
    public interface IClient
    {
        #region Client

        Client GetClient(int clientId);

        Client GetClientWithDetails(int clientId);

        int CreateClient(Client clientData);

        bool UpdateClient(Client clientData);

        IList<Guardian> GetClientGuardians(int clientId);

        IList<CaseIntake> GetClientCases(int clientId);

        #endregion Client

        #region Client Search

        IList<ClientDTO> SearchClients(ClientSearchCriteria sc);

        #endregion Client Search

        #region Client Guardians

        Guardian GetClientGuardian(int guardianId);

        int CreateClientGuardian(Guardian clientGuardian);

        bool UpdateClientGuardian(Guardian clientGuardian);

        #endregion Client Guardians



        #region Client Coverages

        Coverage GetClientCoverage(int clientCoverageId);

        int CreateClientCoverage(Coverage clientCoverage);

        bool UpdateClientCoverage(Coverage clientCoverage);

        IList<Coverage> GetClientCoverages(int clientId);

        #endregion Client Coverages

        //#region Client Contacts

        //ClientContact GetClientContact( int clientContactId );

        //int CreateClientContact( ClientContact clientContact );

        //bool UpdateClientContact( ClientContact clientContact );

        //IList<ClientContact> GetClientContacts( int clientId );

        //#endregion Client Contacts
    }
}