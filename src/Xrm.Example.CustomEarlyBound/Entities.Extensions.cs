using Niam.XRM.Framework.Interfaces.Data;

namespace Xrm.Example.CustomEarlyBound
{
    public static class EntityBaseExt
    {
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy<T>(this IEntityWrapperRelation<T> wrapper, IColumnSet<SystemUser> columnSet)
            where T : EntityBase => wrapper.GetRelated(e => e.CreatedBy, columnSet);

        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate<T>(this IEntityWrapperRelation<T> wrapper, IColumnSet<SystemUser> columnSet)
            where T : EntityBase => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);

        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy<T>(this IEntityWrapperRelation<T> wrapper, IColumnSet<SystemUser> columnSet)
            where T : EntityBase => wrapper.GetRelated(e => e.ModifiedBy, columnSet);

        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate<T>(this IEntityWrapperRelation<T> wrapper, IColumnSet<SystemUser> columnSet)
            where T : EntityBase => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
    }

    public static class UserOrTeamEntityExt
    {
        /// <summary>
        /// Related attribute: owningbusinessunit. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetOwningBusinessUnit<T>(this IEntityWrapperRelation<T> wrapper, IColumnSet<BusinessUnit> columnSet)
            where T : UserOrTeamEntity => wrapper.GetRelated(e => e.OwningBusinessUnit, columnSet);

        /// <summary>
        /// Related attribute: owningteam. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwningTeam<T>(this IEntityWrapperRelation<T> wrapper, IColumnSet<Team> columnSet)
            where T : UserOrTeamEntity => wrapper.GetRelated(e => e.OwningTeam, columnSet);

        /// <summary>
        /// Related attribute: owninguser. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwningUser<T>(this IEntityWrapperRelation<T> wrapper, IColumnSet<SystemUser> columnSet)
            where T : UserOrTeamEntity => wrapper.GetRelated(e => e.OwningUser, columnSet);

        /// <summary>
        /// Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner<T>(this IEntityWrapperRelation<T> wrapper, IColumnSet<Team> columnSet)
            where T : UserOrTeamEntity => wrapper.GetRelated(e => e.OwnerId, columnSet);

        /// <summary>
        /// Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner<T>(this IEntityWrapperRelation<T> wrapper, IColumnSet<SystemUser> columnSet)
            where T : UserOrTeamEntity => wrapper.GetRelated(e => e.OwnerId, columnSet);
    }

    public static class AccountExt
    {
        /// <summary>
        /// Related attribute: masterid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetMasterID(this IEntityWrapperRelation<Account> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.MasterId, columnSet);
        /// <summary>
        /// Related attribute: parentaccountid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetParentAccount(this IEntityWrapperRelation<Account> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.ParentAccountId, columnSet);
        /// <summary>
        /// Related attribute: primarycontactid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetPrimaryContact(this IEntityWrapperRelation<Account> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.PrimaryContactId, columnSet);
        /// <summary>
        /// Related attribute: preferredequipmentid. Lookup to entity: equipment.
        /// </summary>
        public static IEntityWrapper<Equipment> GetPreferredFacilityEquipment(this IEntityWrapperRelation<Account> wrapper, IColumnSet<Equipment> columnSet)
            => wrapper.GetRelated(e => e.PreferredEquipmentId, columnSet);
        /// <summary>
        /// Related attribute: createdbyexternalparty. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetCreatedByExternalParty(this IEntityWrapperRelation<Account> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.CreatedByExternalParty, columnSet);
        /// <summary>
        /// Related attribute: modifiedbyexternalparty. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetModifiedByExternalParty(this IEntityWrapperRelation<Account> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.ModifiedByExternalParty, columnSet);
        /// <summary>
        /// Related attribute: originatingleadid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetOriginatingLead(this IEntityWrapperRelation<Account> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.OriginatingLeadId, columnSet);
        /// <summary>
        /// Related attribute: defaultpricelevelid. Lookup to entity: pricelevel.
        /// </summary>
        public static IEntityWrapper<PriceLevel> GetPriceList(this IEntityWrapperRelation<Account> wrapper, IColumnSet<PriceLevel> columnSet)
            => wrapper.GetRelated(e => e.DefaultPriceLevelId, columnSet);
        /// <summary>
        /// Related attribute: preferredserviceid. Lookup to entity: service.
        /// </summary>
        public static IEntityWrapper<Service> GetPreferredService(this IEntityWrapperRelation<Account> wrapper, IColumnSet<Service> columnSet)
            => wrapper.GetRelated(e => e.PreferredServiceId, columnSet);
        /// <summary>
        /// Related attribute: slaid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetSLA(this IEntityWrapperRelation<Account> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAId, columnSet);
        /// <summary>
        /// Related attribute: slainvokedid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetLastSLAApplied(this IEntityWrapperRelation<Account> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAInvokedId, columnSet);
        /// <summary>
        /// Related attribute: preferredsystemuserid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetPreferredUser(this IEntityWrapperRelation<Account> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.PreferredSystemUserId, columnSet);
        /// <summary>
        /// Related attribute: territoryid. Lookup to entity: territory.
        /// </summary>
        public static IEntityWrapper<Territory> GetTerritory(this IEntityWrapperRelation<Account> wrapper, IColumnSet<Territory> columnSet)
            => wrapper.GetRelated(e => e.TerritoryId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Account> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class ActionCardExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetRegarding(this IEntityWrapperRelation<ActionCard> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: appointment.
        /// </summary>
        public static IEntityWrapper<Appointment> GetRegarding(this IEntityWrapperRelation<ActionCard> wrapper, IColumnSet<Appointment> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetRegarding(this IEntityWrapperRelation<ActionCard> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: email.
        /// </summary>
        public static IEntityWrapper<Email> GetRegarding(this IEntityWrapperRelation<ActionCard> wrapper, IColumnSet<Email> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: fax.
        /// </summary>
        public static IEntityWrapper<Fax> GetRegarding(this IEntityWrapperRelation<ActionCard> wrapper, IColumnSet<Fax> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetRegarding(this IEntityWrapperRelation<ActionCard> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetRegarding(this IEntityWrapperRelation<ActionCard> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: letter.
        /// </summary>
        public static IEntityWrapper<Letter> GetRegarding(this IEntityWrapperRelation<ActionCard> wrapper, IColumnSet<Letter> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetRegarding(this IEntityWrapperRelation<ActionCard> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: phonecall.
        /// </summary>
        public static IEntityWrapper<PhoneCall> GetRegarding(this IEntityWrapperRelation<ActionCard> wrapper, IColumnSet<PhoneCall> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: recurringappointmentmaster.
        /// </summary>
        public static IEntityWrapper<RecurringAppointmentMaster> GetRegarding(this IEntityWrapperRelation<ActionCard> wrapper, IColumnSet<RecurringAppointmentMaster> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: serviceappointment.
        /// </summary>
        public static IEntityWrapper<ServiceAppointment> GetRegarding(this IEntityWrapperRelation<ActionCard> wrapper, IColumnSet<ServiceAppointment> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: task.
        /// </summary>
        public static IEntityWrapper<Task> GetRegarding(this IEntityWrapperRelation<ActionCard> wrapper, IColumnSet<Task> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: cardtypeid. Lookup to entity: cardtype.
        /// </summary>
        public static IEntityWrapper<CardType> GetCardType(this IEntityWrapperRelation<ActionCard> wrapper, IColumnSet<CardType> columnSet)
            => wrapper.GetRelated(e => e.CardTypeId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<ActionCard> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class ActionCardUserSettingsExt
    {
        /// <summary>
        /// Related attribute: cardtypeid. Lookup to entity: cardtype.
        /// </summary>
        public static IEntityWrapper<CardType> GetcardType(this IEntityWrapperRelation<ActionCardUserSettings> wrapper, IColumnSet<CardType> columnSet)
            => wrapper.GetRelated(e => e.CardTypeId, columnSet);

    }
    public static class ActionCardUserStateExt
    {
        /// <summary>
        /// Related attribute: actioncardid. Lookup to entity: actioncard.
        /// </summary>
        public static IEntityWrapper<ActionCard> GetActionCardId(this IEntityWrapperRelation<ActionCardUserState> wrapper, IColumnSet<ActionCard> columnSet)
            => wrapper.GetRelated(e => e.ActionCardId, columnSet);
        /// <summary>
        /// Related attribute: owningbusinessunit. Lookup to entity: actioncard.
        /// </summary>
        public static IEntityWrapper<ActionCard> GetOwningBusinessUnit(this IEntityWrapperRelation<ActionCardUserState> wrapper, IColumnSet<ActionCard> columnSet)
            => wrapper.GetRelated(e => e.OwningBusinessUnit, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<ActionCardUserState> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<ActionCardUserState> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<ActionCardUserState> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class ActivityMimeAttachmentExt
    {
        /// <summary>
        /// Related attribute: activityid. Lookup to entity: activitypointer.
        /// </summary>
        public static IEntityWrapper<ActivityPointer> GetRegarding(this IEntityWrapperRelation<ActivityMimeAttachment> wrapper, IColumnSet<ActivityPointer> columnSet)
            => wrapper.GetRelated(e => e.ActivityId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: activitypointer.
        /// </summary>
        public static IEntityWrapper<ActivityPointer> GetItem(this IEntityWrapperRelation<ActivityMimeAttachment> wrapper, IColumnSet<ActivityPointer> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: template.
        /// </summary>
        public static IEntityWrapper<Template> GetItem(this IEntityWrapperRelation<ActivityMimeAttachment> wrapper, IColumnSet<Template> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Related attribute: attachmentid. Lookup to entity: attachment.
        /// </summary>
        public static IEntityWrapper<Attachment> GetAttachment(this IEntityWrapperRelation<ActivityMimeAttachment> wrapper, IColumnSet<Attachment> columnSet)
            => wrapper.GetRelated(e => e.AttachmentId, columnSet);
        /// <summary>
        /// Related attribute: owningbusinessunit. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetOwningBusinessUnit(this IEntityWrapperRelation<ActivityMimeAttachment> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.OwningBusinessUnit, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<ActivityMimeAttachment> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<ActivityMimeAttachment> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Related attribute: owninguser. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwnerUser(this IEntityWrapperRelation<ActivityMimeAttachment> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwningUser, columnSet);

    }
    public static class ActivityPartyExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: partyid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetParty(this IEntityWrapperRelation<ActivityParty> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.PartyId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: partyid. Lookup to entity: bulkoperation.
        /// </summary>
        public static IEntityWrapper<BulkOperation> GetParty(this IEntityWrapperRelation<ActivityParty> wrapper, IColumnSet<BulkOperation> columnSet)
            => wrapper.GetRelated(e => e.PartyId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: partyid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetParty(this IEntityWrapperRelation<ActivityParty> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.PartyId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: partyid. Lookup to entity: campaignactivity.
        /// </summary>
        public static IEntityWrapper<CampaignActivity> GetParty(this IEntityWrapperRelation<ActivityParty> wrapper, IColumnSet<CampaignActivity> columnSet)
            => wrapper.GetRelated(e => e.PartyId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: partyid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetParty(this IEntityWrapperRelation<ActivityParty> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.PartyId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: partyid. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetParty(this IEntityWrapperRelation<ActivityParty> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.PartyId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: partyid. Lookup to entity: equipment.
        /// </summary>
        public static IEntityWrapper<Equipment> GetParty(this IEntityWrapperRelation<ActivityParty> wrapper, IColumnSet<Equipment> columnSet)
            => wrapper.GetRelated(e => e.PartyId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: partyid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetParty(this IEntityWrapperRelation<ActivityParty> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.PartyId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: partyid. Lookup to entity: invoice.
        /// </summary>
        public static IEntityWrapper<Invoice> GetParty(this IEntityWrapperRelation<ActivityParty> wrapper, IColumnSet<Invoice> columnSet)
            => wrapper.GetRelated(e => e.PartyId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: partyid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetParty(this IEntityWrapperRelation<ActivityParty> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.PartyId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: partyid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetParty(this IEntityWrapperRelation<ActivityParty> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.PartyId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: partyid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetParty(this IEntityWrapperRelation<ActivityParty> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.PartyId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: partyid. Lookup to entity: queue.
        /// </summary>
        public static IEntityWrapper<Queue> GetParty(this IEntityWrapperRelation<ActivityParty> wrapper, IColumnSet<Queue> columnSet)
            => wrapper.GetRelated(e => e.PartyId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: partyid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetParty(this IEntityWrapperRelation<ActivityParty> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.PartyId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: partyid. Lookup to entity: salesorder.
        /// </summary>
        public static IEntityWrapper<SalesOrder> GetParty(this IEntityWrapperRelation<ActivityParty> wrapper, IColumnSet<SalesOrder> columnSet)
            => wrapper.GetRelated(e => e.PartyId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: partyid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetParty(this IEntityWrapperRelation<ActivityParty> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.PartyId, columnSet);
        /// <summary>
        /// Related attribute: activityid. Lookup to entity: activitypointer.
        /// </summary>
        public static IEntityWrapper<ActivityPointer> GetActivity(this IEntityWrapperRelation<ActivityParty> wrapper, IColumnSet<ActivityPointer> columnSet)
            => wrapper.GetRelated(e => e.ActivityId, columnSet);
        /// <summary>
        /// Related attribute: resourcespecid. Lookup to entity: resourcespec.
        /// </summary>
        public static IEntityWrapper<ResourceSpec> GetResourceSpecification(this IEntityWrapperRelation<ActivityParty> wrapper, IColumnSet<ResourceSpec> columnSet)
            => wrapper.GetRelated(e => e.ResourceSpecId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<ActivityParty> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<ActivityParty> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);

    }
    public static class ActivityPointerExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetRegarding(this IEntityWrapperRelation<ActivityPointer> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebooking.
        /// </summary>
        public static IEntityWrapper<BookableResourceBooking> GetRegarding(this IEntityWrapperRelation<ActivityPointer> wrapper, IColumnSet<BookableResourceBooking> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebookingheader.
        /// </summary>
        public static IEntityWrapper<BookableResourceBookingHeader> GetRegarding(this IEntityWrapperRelation<ActivityPointer> wrapper, IColumnSet<BookableResourceBookingHeader> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bulkoperation.
        /// </summary>
        public static IEntityWrapper<BulkOperation> GetRegarding(this IEntityWrapperRelation<ActivityPointer> wrapper, IColumnSet<BulkOperation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetRegarding(this IEntityWrapperRelation<ActivityPointer> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaignactivity.
        /// </summary>
        public static IEntityWrapper<CampaignActivity> GetRegarding(this IEntityWrapperRelation<ActivityPointer> wrapper, IColumnSet<CampaignActivity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetRegarding(this IEntityWrapperRelation<ActivityPointer> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetRegarding(this IEntityWrapperRelation<ActivityPointer> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlement.
        /// </summary>
        public static IEntityWrapper<Entitlement> GetRegarding(this IEntityWrapperRelation<ActivityPointer> wrapper, IColumnSet<Entitlement> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlementtemplate.
        /// </summary>
        public static IEntityWrapper<EntitlementTemplate> GetRegarding(this IEntityWrapperRelation<ActivityPointer> wrapper, IColumnSet<EntitlementTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetRegarding(this IEntityWrapperRelation<ActivityPointer> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: interactionforemail.
        /// </summary>
        public static IEntityWrapper<InteractionForEmail> GetRegarding(this IEntityWrapperRelation<ActivityPointer> wrapper, IColumnSet<InteractionForEmail> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: invoice.
        /// </summary>
        public static IEntityWrapper<Invoice> GetRegarding(this IEntityWrapperRelation<ActivityPointer> wrapper, IColumnSet<Invoice> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetRegarding(this IEntityWrapperRelation<ActivityPointer> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgebaserecord.
        /// </summary>
        public static IEntityWrapper<KnowledgeBaseRecord> GetRegarding(this IEntityWrapperRelation<ActivityPointer> wrapper, IColumnSet<KnowledgeBaseRecord> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetRegarding(this IEntityWrapperRelation<ActivityPointer> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_postalbum.
        /// </summary>
        public static IEntityWrapper<msdyn_PostAlbum> GetRegarding(this IEntityWrapperRelation<ActivityPointer> wrapper, IColumnSet<msdyn_PostAlbum> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetRegarding(this IEntityWrapperRelation<ActivityPointer> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetRegarding(this IEntityWrapperRelation<ActivityPointer> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesorder.
        /// </summary>
        public static IEntityWrapper<SalesOrder> GetRegarding(this IEntityWrapperRelation<ActivityPointer> wrapper, IColumnSet<SalesOrder> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: sendermailboxid. Lookup to entity: mailbox.
        /// </summary>
        public static IEntityWrapper<Mailbox> GetSenderSMailbox(this IEntityWrapperRelation<ActivityPointer> wrapper, IColumnSet<Mailbox> columnSet)
            => wrapper.GetRelated(e => e.SenderMailboxId, columnSet);
        /// <summary>
        /// Related attribute: serviceid. Lookup to entity: service.
        /// </summary>
        public static IEntityWrapper<Service> GetService(this IEntityWrapperRelation<ActivityPointer> wrapper, IColumnSet<Service> columnSet)
            => wrapper.GetRelated(e => e.ServiceId, columnSet);
        /// <summary>
        /// Related attribute: slaid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetSLA(this IEntityWrapperRelation<ActivityPointer> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAId, columnSet);
        /// <summary>
        /// Related attribute: slainvokedid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetLastSLAApplied(this IEntityWrapperRelation<ActivityPointer> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAInvokedId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<ActivityPointer> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class AdvancedSimilarityRuleExt
    {
        /// <summary>
        /// Related attribute: azureserviceconnectionid. Lookup to entity: azureserviceconnection.
        /// </summary>
        public static IEntityWrapper<AzureServiceConnection> GetConnection(this IEntityWrapperRelation<AdvancedSimilarityRule> wrapper, IColumnSet<AzureServiceConnection> columnSet)
            => wrapper.GetRelated(e => e.AzureServiceConnectionId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<AdvancedSimilarityRule> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class AnnotationExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: appointment.
        /// </summary>
        public static IEntityWrapper<Appointment> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<Appointment> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bookableresource.
        /// </summary>
        public static IEntityWrapper<BookableResource> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<BookableResource> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bookableresourcebooking.
        /// </summary>
        public static IEntityWrapper<BookableResourceBooking> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<BookableResourceBooking> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bookableresourcebookingheader.
        /// </summary>
        public static IEntityWrapper<BookableResourceBookingHeader> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<BookableResourceBookingHeader> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bookableresourcecategoryassn.
        /// </summary>
        public static IEntityWrapper<BookableResourceCategoryAssn> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<BookableResourceCategoryAssn> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bookableresourcecharacteristic.
        /// </summary>
        public static IEntityWrapper<BookableResourceCharacteristic> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<BookableResourceCharacteristic> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bookableresourcegroup.
        /// </summary>
        public static IEntityWrapper<BookableResourceGroup> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<BookableResourceGroup> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: calendar.
        /// </summary>
        public static IEntityWrapper<Calendar> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<Calendar> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: campaignactivity.
        /// </summary>
        public static IEntityWrapper<CampaignActivity> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<CampaignActivity> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: campaignresponse.
        /// </summary>
        public static IEntityWrapper<CampaignResponse> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<CampaignResponse> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: channelaccessprofile.
        /// </summary>
        public static IEntityWrapper<ChannelAccessProfile> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<ChannelAccessProfile> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: channelaccessprofilerule.
        /// </summary>
        public static IEntityWrapper<ChannelAccessProfileRule> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<ChannelAccessProfileRule> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: channelaccessprofileruleitem.
        /// </summary>
        public static IEntityWrapper<ChannelAccessProfileRuleItem> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<ChannelAccessProfileRuleItem> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: commitment.
        /// </summary>
        public static IEntityWrapper<Commitment> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<Commitment> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: competitor.
        /// </summary>
        public static IEntityWrapper<Competitor> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<Competitor> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: contractdetail.
        /// </summary>
        public static IEntityWrapper<ContractDetail> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<ContractDetail> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: convertrule.
        /// </summary>
        public static IEntityWrapper<ConvertRule> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<ConvertRule> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: duplicaterule.
        /// </summary>
        public static IEntityWrapper<DuplicateRule> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<DuplicateRule> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: email.
        /// </summary>
        public static IEntityWrapper<Email> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<Email> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: emailserverprofile.
        /// </summary>
        public static IEntityWrapper<EmailServerProfile> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<EmailServerProfile> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: entitlement.
        /// </summary>
        public static IEntityWrapper<Entitlement> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<Entitlement> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: entitlementchannel.
        /// </summary>
        public static IEntityWrapper<EntitlementChannel> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<EntitlementChannel> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: entitlementtemplate.
        /// </summary>
        public static IEntityWrapper<EntitlementTemplate> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<EntitlementTemplate> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: equipment.
        /// </summary>
        public static IEntityWrapper<Equipment> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<Equipment> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: fax.
        /// </summary>
        public static IEntityWrapper<Fax> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<Fax> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: goal.
        /// </summary>
        public static IEntityWrapper<Goal> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<Goal> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: incidentresolution.
        /// </summary>
        public static IEntityWrapper<IncidentResolution> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<IncidentResolution> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: invoice.
        /// </summary>
        public static IEntityWrapper<Invoice> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<Invoice> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: kbarticle.
        /// </summary>
        public static IEntityWrapper<KbArticle> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<KbArticle> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: knowledgebaserecord.
        /// </summary>
        public static IEntityWrapper<KnowledgeBaseRecord> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<KnowledgeBaseRecord> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: letter.
        /// </summary>
        public static IEntityWrapper<Letter> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<Letter> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: list.
        /// </summary>
        public static IEntityWrapper<List> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<List> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: mailbox.
        /// </summary>
        public static IEntityWrapper<Mailbox> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<Mailbox> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: msdyn_postalbum.
        /// </summary>
        public static IEntityWrapper<msdyn_PostAlbum> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<msdyn_PostAlbum> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: opportunityclose.
        /// </summary>
        public static IEntityWrapper<OpportunityClose> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<OpportunityClose> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: orderclose.
        /// </summary>
        public static IEntityWrapper<OrderClose> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<OrderClose> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: phonecall.
        /// </summary>
        public static IEntityWrapper<PhoneCall> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<PhoneCall> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: quoteclose.
        /// </summary>
        public static IEntityWrapper<QuoteClose> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<QuoteClose> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: recurringappointmentmaster.
        /// </summary>
        public static IEntityWrapper<RecurringAppointmentMaster> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<RecurringAppointmentMaster> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: resourcespec.
        /// </summary>
        public static IEntityWrapper<ResourceSpec> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<ResourceSpec> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: routingrule.
        /// </summary>
        public static IEntityWrapper<RoutingRule> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<RoutingRule> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: routingruleitem.
        /// </summary>
        public static IEntityWrapper<RoutingRuleItem> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<RoutingRuleItem> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: salesorder.
        /// </summary>
        public static IEntityWrapper<SalesOrder> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<SalesOrder> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: service.
        /// </summary>
        public static IEntityWrapper<Service> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<Service> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: serviceappointment.
        /// </summary>
        public static IEntityWrapper<ServiceAppointment> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<ServiceAppointment> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: sharepointdocument.
        /// </summary>
        public static IEntityWrapper<SharePointDocument> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<SharePointDocument> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: socialactivity.
        /// </summary>
        public static IEntityWrapper<SocialActivity> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<SocialActivity> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: task.
        /// </summary>
        public static IEntityWrapper<Task> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<Task> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: workflow.
        /// </summary>
        public static IEntityWrapper<Workflow> GetRegarding(this IEntityWrapperRelation<Annotation> wrapper, IColumnSet<Workflow> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);

    }
    public static class AnnualFiscalCalendarExt
    {
        /// <summary>
        /// Related attribute: businessunitid. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetBusinessUnitId(this IEntityWrapperRelation<AnnualFiscalCalendar> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.BusinessUnitId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<AnnualFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedOnBehalfBy(this IEntityWrapperRelation<AnnualFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<AnnualFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedOnBehalfBy(this IEntityWrapperRelation<AnnualFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: salespersonid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetSalesPersonId(this IEntityWrapperRelation<AnnualFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.SalesPersonId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<AnnualFiscalCalendar> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class ApplicationFileExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<ApplicationFile> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class AppModuleExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<AppModule> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: publisherid. Lookup to entity: publisher.
        /// </summary>
        public static IEntityWrapper<Publisher> GetPublisher(this IEntityWrapperRelation<AppModule> wrapper, IColumnSet<Publisher> columnSet)
            => wrapper.GetRelated(e => e.PublisherId, columnSet);

    }
    public static class AppModuleComponentExt
    {
        /// <summary>
        /// Related attribute: appmoduleidunique. Lookup to entity: appmodule.
        /// </summary>
        public static IEntityWrapper<AppModule> GetAppModule(this IEntityWrapperRelation<AppModuleComponent> wrapper, IColumnSet<AppModule> columnSet)
            => wrapper.GetRelated(e => e.AppModuleIdUnique, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<AppModuleComponent> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<AppModuleComponent> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<AppModuleComponent> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<AppModuleComponent> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);

    }
    public static class AppModuleRolesExt
    {
        /// <summary>
        /// Related attribute: appmoduleid. Lookup to entity: appmodule.
        /// </summary>
        public static IEntityWrapper<AppModule> GetAppModule(this IEntityWrapperRelation<AppModuleRoles> wrapper, IColumnSet<AppModule> columnSet)
            => wrapper.GetRelated(e => e.AppModuleId, columnSet);
        /// <summary>
        /// Related attribute: roleid. Lookup to entity: role.
        /// </summary>
        public static IEntityWrapper<Role> GetRole(this IEntityWrapperRelation<AppModuleRoles> wrapper, IColumnSet<Role> columnSet)
            => wrapper.GetRelated(e => e.RoleId, columnSet);

    }
    public static class AppointmentExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetRegarding(this IEntityWrapperRelation<Appointment> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebooking.
        /// </summary>
        public static IEntityWrapper<BookableResourceBooking> GetRegarding(this IEntityWrapperRelation<Appointment> wrapper, IColumnSet<BookableResourceBooking> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebookingheader.
        /// </summary>
        public static IEntityWrapper<BookableResourceBookingHeader> GetRegarding(this IEntityWrapperRelation<Appointment> wrapper, IColumnSet<BookableResourceBookingHeader> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bulkoperation.
        /// </summary>
        public static IEntityWrapper<BulkOperation> GetRegarding(this IEntityWrapperRelation<Appointment> wrapper, IColumnSet<BulkOperation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetRegarding(this IEntityWrapperRelation<Appointment> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaignactivity.
        /// </summary>
        public static IEntityWrapper<CampaignActivity> GetRegarding(this IEntityWrapperRelation<Appointment> wrapper, IColumnSet<CampaignActivity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetRegarding(this IEntityWrapperRelation<Appointment> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetRegarding(this IEntityWrapperRelation<Appointment> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlement.
        /// </summary>
        public static IEntityWrapper<Entitlement> GetRegarding(this IEntityWrapperRelation<Appointment> wrapper, IColumnSet<Entitlement> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlementtemplate.
        /// </summary>
        public static IEntityWrapper<EntitlementTemplate> GetRegarding(this IEntityWrapperRelation<Appointment> wrapper, IColumnSet<EntitlementTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetRegarding(this IEntityWrapperRelation<Appointment> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: invoice.
        /// </summary>
        public static IEntityWrapper<Invoice> GetRegarding(this IEntityWrapperRelation<Appointment> wrapper, IColumnSet<Invoice> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetRegarding(this IEntityWrapperRelation<Appointment> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgebaserecord.
        /// </summary>
        public static IEntityWrapper<KnowledgeBaseRecord> GetRegarding(this IEntityWrapperRelation<Appointment> wrapper, IColumnSet<KnowledgeBaseRecord> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetRegarding(this IEntityWrapperRelation<Appointment> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_postalbum.
        /// </summary>
        public static IEntityWrapper<msdyn_PostAlbum> GetRegarding(this IEntityWrapperRelation<Appointment> wrapper, IColumnSet<msdyn_PostAlbum> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetRegarding(this IEntityWrapperRelation<Appointment> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetRegarding(this IEntityWrapperRelation<Appointment> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesorder.
        /// </summary>
        public static IEntityWrapper<SalesOrder> GetRegarding(this IEntityWrapperRelation<Appointment> wrapper, IColumnSet<SalesOrder> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: serviceid. Lookup to entity: service.
        /// </summary>
        public static IEntityWrapper<Service> GetService(this IEntityWrapperRelation<Appointment> wrapper, IColumnSet<Service> columnSet)
            => wrapper.GetRelated(e => e.ServiceId, columnSet);
        /// <summary>
        /// Related attribute: slaid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetSLA(this IEntityWrapperRelation<Appointment> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAId, columnSet);
        /// <summary>
        /// Related attribute: slainvokedid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetLastSLAApplied(this IEntityWrapperRelation<Appointment> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAInvokedId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Appointment> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class AsyncOperationExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: activitymimeattachment.
        /// </summary>
        public static IEntityWrapper<ActivityMimeAttachment> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<ActivityMimeAttachment> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: activitypointer.
        /// </summary>
        public static IEntityWrapper<ActivityPointer> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<ActivityPointer> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: annotation.
        /// </summary>
        public static IEntityWrapper<Annotation> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Annotation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: annualfiscalcalendar.
        /// </summary>
        public static IEntityWrapper<AnnualFiscalCalendar> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<AnnualFiscalCalendar> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: appointment.
        /// </summary>
        public static IEntityWrapper<Appointment> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Appointment> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: attributemap.
        /// </summary>
        public static IEntityWrapper<AttributeMap> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<AttributeMap> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresource.
        /// </summary>
        public static IEntityWrapper<BookableResource> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<BookableResource> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebooking.
        /// </summary>
        public static IEntityWrapper<BookableResourceBooking> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<BookableResourceBooking> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebookingheader.
        /// </summary>
        public static IEntityWrapper<BookableResourceBookingHeader> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<BookableResourceBookingHeader> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcecategory.
        /// </summary>
        public static IEntityWrapper<BookableResourceCategory> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<BookableResourceCategory> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcecategoryassn.
        /// </summary>
        public static IEntityWrapper<BookableResourceCategoryAssn> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<BookableResourceCategoryAssn> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcecharacteristic.
        /// </summary>
        public static IEntityWrapper<BookableResourceCharacteristic> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<BookableResourceCharacteristic> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcegroup.
        /// </summary>
        public static IEntityWrapper<BookableResourceGroup> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<BookableResourceGroup> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookingstatus.
        /// </summary>
        public static IEntityWrapper<BookingStatus> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<BookingStatus> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bulkoperation.
        /// </summary>
        public static IEntityWrapper<BulkOperation> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<BulkOperation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bulkoperationlog.
        /// </summary>
        public static IEntityWrapper<BulkOperationLog> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<BulkOperationLog> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: businessunitnewsarticle.
        /// </summary>
        public static IEntityWrapper<BusinessUnitNewsArticle> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<BusinessUnitNewsArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: calendar.
        /// </summary>
        public static IEntityWrapper<Calendar> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Calendar> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaignactivity.
        /// </summary>
        public static IEntityWrapper<CampaignActivity> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<CampaignActivity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaignresponse.
        /// </summary>
        public static IEntityWrapper<CampaignResponse> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<CampaignResponse> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: channelaccessprofile.
        /// </summary>
        public static IEntityWrapper<ChannelAccessProfile> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<ChannelAccessProfile> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: channelaccessprofilerule.
        /// </summary>
        public static IEntityWrapper<ChannelAccessProfileRule> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<ChannelAccessProfileRule> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: characteristic.
        /// </summary>
        public static IEntityWrapper<Characteristic> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Characteristic> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: competitor.
        /// </summary>
        public static IEntityWrapper<Competitor> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Competitor> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: connection.
        /// </summary>
        public static IEntityWrapper<Connection> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Connection> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: connectionrole.
        /// </summary>
        public static IEntityWrapper<ConnectionRole> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<ConnectionRole> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: constraintbasedgroup.
        /// </summary>
        public static IEntityWrapper<ConstraintBasedGroup> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<ConstraintBasedGroup> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contractdetail.
        /// </summary>
        public static IEntityWrapper<ContractDetail> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<ContractDetail> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contracttemplate.
        /// </summary>
        public static IEntityWrapper<ContractTemplate> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<ContractTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: convertrule.
        /// </summary>
        public static IEntityWrapper<ConvertRule> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<ConvertRule> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: customeraddress.
        /// </summary>
        public static IEntityWrapper<CustomerAddress> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<CustomerAddress> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: customeropportunityrole.
        /// </summary>
        public static IEntityWrapper<CustomerOpportunityRole> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<CustomerOpportunityRole> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: customerrelationship.
        /// </summary>
        public static IEntityWrapper<CustomerRelationship> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<CustomerRelationship> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: discount.
        /// </summary>
        public static IEntityWrapper<Discount> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Discount> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: discounttype.
        /// </summary>
        public static IEntityWrapper<DiscountType> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<DiscountType> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: displaystring.
        /// </summary>
        public static IEntityWrapper<DisplayString> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<DisplayString> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: email.
        /// </summary>
        public static IEntityWrapper<Email> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Email> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: emailserverprofile.
        /// </summary>
        public static IEntityWrapper<EmailServerProfile> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<EmailServerProfile> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlement.
        /// </summary>
        public static IEntityWrapper<Entitlement> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Entitlement> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlementchannel.
        /// </summary>
        public static IEntityWrapper<EntitlementChannel> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<EntitlementChannel> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlementtemplate.
        /// </summary>
        public static IEntityWrapper<EntitlementTemplate> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<EntitlementTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitymap.
        /// </summary>
        public static IEntityWrapper<EntityMap> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<EntityMap> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: equipment.
        /// </summary>
        public static IEntityWrapper<Equipment> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Equipment> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: externalpartyitem.
        /// </summary>
        public static IEntityWrapper<ExternalPartyItem> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<ExternalPartyItem> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: fax.
        /// </summary>
        public static IEntityWrapper<Fax> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Fax> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: fixedmonthlyfiscalcalendar.
        /// </summary>
        public static IEntityWrapper<FixedMonthlyFiscalCalendar> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<FixedMonthlyFiscalCalendar> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: goal.
        /// </summary>
        public static IEntityWrapper<Goal> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Goal> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: goalrollupquery.
        /// </summary>
        public static IEntityWrapper<GoalRollupQuery> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<GoalRollupQuery> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: import.
        /// </summary>
        public static IEntityWrapper<Import> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Import> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: importdata.
        /// </summary>
        public static IEntityWrapper<ImportData> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<ImportData> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: importfile.
        /// </summary>
        public static IEntityWrapper<ImportFile> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<ImportFile> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: importlog.
        /// </summary>
        public static IEntityWrapper<ImportLog> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<ImportLog> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: importmap.
        /// </summary>
        public static IEntityWrapper<ImportMap> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<ImportMap> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: incidentresolution.
        /// </summary>
        public static IEntityWrapper<IncidentResolution> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<IncidentResolution> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: ins_salesorder.
        /// </summary>
        public static IEntityWrapper<ins_salesorder> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<ins_salesorder> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: ins_salesorderline.
        /// </summary>
        public static IEntityWrapper<ins_salesorderline> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<ins_salesorderline> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: interactionforemail.
        /// </summary>
        public static IEntityWrapper<InteractionForEmail> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<InteractionForEmail> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: invoice.
        /// </summary>
        public static IEntityWrapper<Invoice> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Invoice> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: invoicedetail.
        /// </summary>
        public static IEntityWrapper<InvoiceDetail> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<InvoiceDetail> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: isvconfig.
        /// </summary>
        public static IEntityWrapper<IsvConfig> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<IsvConfig> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: kbarticle.
        /// </summary>
        public static IEntityWrapper<KbArticle> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<KbArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: kbarticlecomment.
        /// </summary>
        public static IEntityWrapper<KbArticleComment> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<KbArticleComment> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: kbarticletemplate.
        /// </summary>
        public static IEntityWrapper<KbArticleTemplate> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<KbArticleTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgebaserecord.
        /// </summary>
        public static IEntityWrapper<KnowledgeBaseRecord> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<KnowledgeBaseRecord> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: letter.
        /// </summary>
        public static IEntityWrapper<Letter> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Letter> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: list.
        /// </summary>
        public static IEntityWrapper<List> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<List> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: mailbox.
        /// </summary>
        public static IEntityWrapper<Mailbox> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Mailbox> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: mailmergetemplate.
        /// </summary>
        public static IEntityWrapper<MailMergeTemplate> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<MailMergeTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: metric.
        /// </summary>
        public static IEntityWrapper<Metric> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Metric> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: monthlyfiscalcalendar.
        /// </summary>
        public static IEntityWrapper<MonthlyFiscalCalendar> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<MonthlyFiscalCalendar> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_postalbum.
        /// </summary>
        public static IEntityWrapper<msdyn_PostAlbum> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<msdyn_PostAlbum> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_postconfig.
        /// </summary>
        public static IEntityWrapper<msdyn_PostConfig> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<msdyn_PostConfig> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_postruleconfig.
        /// </summary>
        public static IEntityWrapper<msdyn_PostRuleConfig> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<msdyn_PostRuleConfig> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_wallsavedquery.
        /// </summary>
        public static IEntityWrapper<msdyn_wallsavedquery> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<msdyn_wallsavedquery> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_wallsavedqueryusersettings.
        /// </summary>
        public static IEntityWrapper<msdyn_wallsavedqueryusersettings> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<msdyn_wallsavedqueryusersettings> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunityclose.
        /// </summary>
        public static IEntityWrapper<OpportunityClose> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<OpportunityClose> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunityproduct.
        /// </summary>
        public static IEntityWrapper<OpportunityProduct> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<OpportunityProduct> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: orderclose.
        /// </summary>
        public static IEntityWrapper<OrderClose> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<OrderClose> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: phonecall.
        /// </summary>
        public static IEntityWrapper<PhoneCall> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<PhoneCall> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: position.
        /// </summary>
        public static IEntityWrapper<Position> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Position> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: post.
        /// </summary>
        public static IEntityWrapper<Post> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Post> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: postfollow.
        /// </summary>
        public static IEntityWrapper<PostFollow> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<PostFollow> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: pricelevel.
        /// </summary>
        public static IEntityWrapper<PriceLevel> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<PriceLevel> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: privilege.
        /// </summary>
        public static IEntityWrapper<Privilege> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Privilege> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: productassociation.
        /// </summary>
        public static IEntityWrapper<ProductAssociation> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<ProductAssociation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: productpricelevel.
        /// </summary>
        public static IEntityWrapper<ProductPriceLevel> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<ProductPriceLevel> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: productsubstitute.
        /// </summary>
        public static IEntityWrapper<ProductSubstitute> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<ProductSubstitute> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quarterlyfiscalcalendar.
        /// </summary>
        public static IEntityWrapper<QuarterlyFiscalCalendar> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<QuarterlyFiscalCalendar> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: queue.
        /// </summary>
        public static IEntityWrapper<Queue> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Queue> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: queueitem.
        /// </summary>
        public static IEntityWrapper<QueueItem> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<QueueItem> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quoteclose.
        /// </summary>
        public static IEntityWrapper<QuoteClose> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<QuoteClose> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quotedetail.
        /// </summary>
        public static IEntityWrapper<QuoteDetail> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<QuoteDetail> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: ratingmodel.
        /// </summary>
        public static IEntityWrapper<RatingModel> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<RatingModel> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: ratingvalue.
        /// </summary>
        public static IEntityWrapper<RatingValue> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<RatingValue> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: recurringappointmentmaster.
        /// </summary>
        public static IEntityWrapper<RecurringAppointmentMaster> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<RecurringAppointmentMaster> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: relationshiprole.
        /// </summary>
        public static IEntityWrapper<RelationshipRole> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<RelationshipRole> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: relationshiprolemap.
        /// </summary>
        public static IEntityWrapper<RelationshipRoleMap> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<RelationshipRoleMap> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: report.
        /// </summary>
        public static IEntityWrapper<Report> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Report> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: resource.
        /// </summary>
        public static IEntityWrapper<Resource> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Resource> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: resourcegroup.
        /// </summary>
        public static IEntityWrapper<ResourceGroup> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<ResourceGroup> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: resourcespec.
        /// </summary>
        public static IEntityWrapper<ResourceSpec> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<ResourceSpec> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: role.
        /// </summary>
        public static IEntityWrapper<Role> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Role> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: rollupfield.
        /// </summary>
        public static IEntityWrapper<RollupField> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<RollupField> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: routingrule.
        /// </summary>
        public static IEntityWrapper<RoutingRule> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<RoutingRule> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: routingruleitem.
        /// </summary>
        public static IEntityWrapper<RoutingRuleItem> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<RoutingRuleItem> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesliterature.
        /// </summary>
        public static IEntityWrapper<SalesLiterature> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<SalesLiterature> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesliteratureitem.
        /// </summary>
        public static IEntityWrapper<SalesLiteratureItem> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<SalesLiteratureItem> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesorder.
        /// </summary>
        public static IEntityWrapper<SalesOrder> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<SalesOrder> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesorderdetail.
        /// </summary>
        public static IEntityWrapper<SalesOrderDetail> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<SalesOrderDetail> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: savedquery.
        /// </summary>
        public static IEntityWrapper<SavedQuery> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<SavedQuery> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: semiannualfiscalcalendar.
        /// </summary>
        public static IEntityWrapper<SemiAnnualFiscalCalendar> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<SemiAnnualFiscalCalendar> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: service.
        /// </summary>
        public static IEntityWrapper<Service> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Service> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: serviceappointment.
        /// </summary>
        public static IEntityWrapper<ServiceAppointment> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<ServiceAppointment> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: sharepointdocumentlocation.
        /// </summary>
        public static IEntityWrapper<SharePointDocumentLocation> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<SharePointDocumentLocation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: sharepointsite.
        /// </summary>
        public static IEntityWrapper<SharePointSite> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<SharePointSite> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: similarityrule.
        /// </summary>
        public static IEntityWrapper<SimilarityRule> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<SimilarityRule> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: site.
        /// </summary>
        public static IEntityWrapper<Site> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Site> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: socialactivity.
        /// </summary>
        public static IEntityWrapper<SocialActivity> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<SocialActivity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: socialprofile.
        /// </summary>
        public static IEntityWrapper<SocialProfile> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<SocialProfile> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: subject.
        /// </summary>
        public static IEntityWrapper<Subject> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Subject> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: systemform.
        /// </summary>
        public static IEntityWrapper<SystemForm> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<SystemForm> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: task.
        /// </summary>
        public static IEntityWrapper<Task> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Task> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: template.
        /// </summary>
        public static IEntityWrapper<Template> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Template> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: territory.
        /// </summary>
        public static IEntityWrapper<Territory> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Territory> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: theme.
        /// </summary>
        public static IEntityWrapper<Theme> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Theme> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: uom.
        /// </summary>
        public static IEntityWrapper<UoM> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<UoM> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: uomschedule.
        /// </summary>
        public static IEntityWrapper<UoMSchedule> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<UoMSchedule> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: userform.
        /// </summary>
        public static IEntityWrapper<UserForm> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<UserForm> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: usermapping.
        /// </summary>
        public static IEntityWrapper<UserMapping> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<UserMapping> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: userquery.
        /// </summary>
        public static IEntityWrapper<UserQuery> GetRegarding(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<UserQuery> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: owningextensionid. Lookup to entity: sdkmessageprocessingstep.
        /// </summary>
        public static IEntityWrapper<SdkMessageProcessingStep> GetOwningExtension(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<SdkMessageProcessingStep> columnSet)
            => wrapper.GetRelated(e => e.OwningExtensionId, columnSet);
        /// <summary>
        /// Related attribute: workflowactivationid. Lookup to entity: workflow.
        /// </summary>
        public static IEntityWrapper<Workflow> GetWorkflowActivationId(this IEntityWrapperRelation<AsyncOperation> wrapper, IColumnSet<Workflow> columnSet)
            => wrapper.GetRelated(e => e.WorkflowActivationId, columnSet);

    }
    public static class AttributeMapExt
    {
        /// <summary>
        /// Related attribute: parentattributemapid. Lookup to entity: attributemap.
        /// </summary>
        public static IEntityWrapper<AttributeMap> GetParentAttributeMapId(this IEntityWrapperRelation<AttributeMap> wrapper, IColumnSet<AttributeMap> columnSet)
            => wrapper.GetRelated(e => e.ParentAttributeMapId, columnSet);
        /// <summary>
        /// Related attribute: entitymapid. Lookup to entity: entitymap.
        /// </summary>
        public static IEntityWrapper<EntityMap> GetEntityMapId(this IEntityWrapperRelation<AttributeMap> wrapper, IColumnSet<EntityMap> columnSet)
            => wrapper.GetRelated(e => e.EntityMapId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<AttributeMap> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class AuditExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: userid. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetChangedBy(this IEntityWrapperRelation<Audit> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.UserId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: userid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetChangedBy(this IEntityWrapperRelation<Audit> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.UserId, columnSet);
        /// <summary>
        /// Related attribute: callinguserid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCallingUser(this IEntityWrapperRelation<Audit> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CallingUserId, columnSet);

    }
    public static class AuthorizationServerExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<AuthorizationServer> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class AzureServiceConnectionExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<AzureServiceConnection> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class BookableResourceExt
    {
        /// <summary>
        /// Related attribute: accountid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetAccount(this IEntityWrapperRelation<BookableResource> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.AccountId, columnSet);
        /// <summary>
        /// Related attribute: calendarid. Lookup to entity: calendar.
        /// </summary>
        public static IEntityWrapper<Calendar> GetCalendar(this IEntityWrapperRelation<BookableResource> wrapper, IColumnSet<Calendar> columnSet)
            => wrapper.GetRelated(e => e.CalendarId, columnSet);
        /// <summary>
        /// Related attribute: contactid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetContact(this IEntityWrapperRelation<BookableResource> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.ContactId, columnSet);
        /// <summary>
        /// Related attribute: userid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetUser(this IEntityWrapperRelation<BookableResource> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.UserId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<BookableResource> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class BookableResourceBookingExt
    {
        /// <summary>
        /// Related attribute: resource. Lookup to entity: bookableresource.
        /// </summary>
        public static IEntityWrapper<BookableResource> GetResource(this IEntityWrapperRelation<BookableResourceBooking> wrapper, IColumnSet<BookableResource> columnSet)
            => wrapper.GetRelated(e => e.Resource, columnSet);
        /// <summary>
        /// Related attribute: header. Lookup to entity: bookableresourcebookingheader.
        /// </summary>
        public static IEntityWrapper<BookableResourceBookingHeader> GetHeader(this IEntityWrapperRelation<BookableResourceBooking> wrapper, IColumnSet<BookableResourceBookingHeader> columnSet)
            => wrapper.GetRelated(e => e.Header, columnSet);
        /// <summary>
        /// Related attribute: bookingstatus. Lookup to entity: bookingstatus.
        /// </summary>
        public static IEntityWrapper<BookingStatus> GetBookingStatus(this IEntityWrapperRelation<BookableResourceBooking> wrapper, IColumnSet<BookingStatus> columnSet)
            => wrapper.GetRelated(e => e.BookingStatus, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<BookableResourceBooking> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class BookableResourceBookingExchangeSyncIdMappingExt
    {

    }
    public static class BookableResourceBookingHeaderExt
    {
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<BookableResourceBookingHeader> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class BookableResourceCategoryExt
    {
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<BookableResourceCategory> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class BookableResourceCategoryAssnExt
    {
        /// <summary>
        /// Related attribute: resource. Lookup to entity: bookableresource.
        /// </summary>
        public static IEntityWrapper<BookableResource> GetResource(this IEntityWrapperRelation<BookableResourceCategoryAssn> wrapper, IColumnSet<BookableResource> columnSet)
            => wrapper.GetRelated(e => e.Resource, columnSet);
        /// <summary>
        /// Related attribute: resourcecategory. Lookup to entity: bookableresourcecategory.
        /// </summary>
        public static IEntityWrapper<BookableResourceCategory> GetResourceCategory(this IEntityWrapperRelation<BookableResourceCategoryAssn> wrapper, IColumnSet<BookableResourceCategory> columnSet)
            => wrapper.GetRelated(e => e.ResourceCategory, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<BookableResourceCategoryAssn> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class BookableResourceCharacteristicExt
    {
        /// <summary>
        /// Related attribute: resource. Lookup to entity: bookableresource.
        /// </summary>
        public static IEntityWrapper<BookableResource> GetResource(this IEntityWrapperRelation<BookableResourceCharacteristic> wrapper, IColumnSet<BookableResource> columnSet)
            => wrapper.GetRelated(e => e.Resource, columnSet);
        /// <summary>
        /// Related attribute: characteristic. Lookup to entity: characteristic.
        /// </summary>
        public static IEntityWrapper<Characteristic> GetCharacteristic(this IEntityWrapperRelation<BookableResourceCharacteristic> wrapper, IColumnSet<Characteristic> columnSet)
            => wrapper.GetRelated(e => e.Characteristic, columnSet);
        /// <summary>
        /// Related attribute: ratingvalue. Lookup to entity: ratingvalue.
        /// </summary>
        public static IEntityWrapper<RatingValue> GetRatingValue(this IEntityWrapperRelation<BookableResourceCharacteristic> wrapper, IColumnSet<RatingValue> columnSet)
            => wrapper.GetRelated(e => e.RatingValue, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<BookableResourceCharacteristic> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class BookableResourceGroupExt
    {
        /// <summary>
        /// Related attribute: childresource. Lookup to entity: bookableresource.
        /// </summary>
        public static IEntityWrapper<BookableResource> GetChildResource(this IEntityWrapperRelation<BookableResourceGroup> wrapper, IColumnSet<BookableResource> columnSet)
            => wrapper.GetRelated(e => e.ChildResource, columnSet);
        /// <summary>
        /// Related attribute: parentresource. Lookup to entity: bookableresource.
        /// </summary>
        public static IEntityWrapper<BookableResource> GetParentResource(this IEntityWrapperRelation<BookableResourceGroup> wrapper, IColumnSet<BookableResource> columnSet)
            => wrapper.GetRelated(e => e.ParentResource, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<BookableResourceGroup> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class BookingStatusExt
    {
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<BookingStatus> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class BulkDeleteFailureExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: activitymimeattachment.
        /// </summary>
        public static IEntityWrapper<ActivityMimeAttachment> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<ActivityMimeAttachment> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: activitypointer.
        /// </summary>
        public static IEntityWrapper<ActivityPointer> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<ActivityPointer> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: annotation.
        /// </summary>
        public static IEntityWrapper<Annotation> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Annotation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: annualfiscalcalendar.
        /// </summary>
        public static IEntityWrapper<AnnualFiscalCalendar> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<AnnualFiscalCalendar> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: appointment.
        /// </summary>
        public static IEntityWrapper<Appointment> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Appointment> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: attributemap.
        /// </summary>
        public static IEntityWrapper<AttributeMap> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<AttributeMap> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresource.
        /// </summary>
        public static IEntityWrapper<BookableResource> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<BookableResource> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebooking.
        /// </summary>
        public static IEntityWrapper<BookableResourceBooking> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<BookableResourceBooking> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebookingheader.
        /// </summary>
        public static IEntityWrapper<BookableResourceBookingHeader> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<BookableResourceBookingHeader> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcecategory.
        /// </summary>
        public static IEntityWrapper<BookableResourceCategory> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<BookableResourceCategory> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcecategoryassn.
        /// </summary>
        public static IEntityWrapper<BookableResourceCategoryAssn> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<BookableResourceCategoryAssn> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcecharacteristic.
        /// </summary>
        public static IEntityWrapper<BookableResourceCharacteristic> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<BookableResourceCharacteristic> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcegroup.
        /// </summary>
        public static IEntityWrapper<BookableResourceGroup> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<BookableResourceGroup> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookingstatus.
        /// </summary>
        public static IEntityWrapper<BookingStatus> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<BookingStatus> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bulkoperation.
        /// </summary>
        public static IEntityWrapper<BulkOperation> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<BulkOperation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bulkoperationlog.
        /// </summary>
        public static IEntityWrapper<BulkOperationLog> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<BulkOperationLog> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: businessunitnewsarticle.
        /// </summary>
        public static IEntityWrapper<BusinessUnitNewsArticle> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<BusinessUnitNewsArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: calendar.
        /// </summary>
        public static IEntityWrapper<Calendar> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Calendar> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaignactivity.
        /// </summary>
        public static IEntityWrapper<CampaignActivity> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<CampaignActivity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaignresponse.
        /// </summary>
        public static IEntityWrapper<CampaignResponse> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<CampaignResponse> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: channelaccessprofile.
        /// </summary>
        public static IEntityWrapper<ChannelAccessProfile> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<ChannelAccessProfile> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: channelaccessprofilerule.
        /// </summary>
        public static IEntityWrapper<ChannelAccessProfileRule> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<ChannelAccessProfileRule> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: characteristic.
        /// </summary>
        public static IEntityWrapper<Characteristic> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Characteristic> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: competitor.
        /// </summary>
        public static IEntityWrapper<Competitor> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Competitor> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: constraintbasedgroup.
        /// </summary>
        public static IEntityWrapper<ConstraintBasedGroup> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<ConstraintBasedGroup> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contractdetail.
        /// </summary>
        public static IEntityWrapper<ContractDetail> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<ContractDetail> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contracttemplate.
        /// </summary>
        public static IEntityWrapper<ContractTemplate> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<ContractTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: customeraddress.
        /// </summary>
        public static IEntityWrapper<CustomerAddress> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<CustomerAddress> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: customeropportunityrole.
        /// </summary>
        public static IEntityWrapper<CustomerOpportunityRole> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<CustomerOpportunityRole> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: customerrelationship.
        /// </summary>
        public static IEntityWrapper<CustomerRelationship> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<CustomerRelationship> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: discount.
        /// </summary>
        public static IEntityWrapper<Discount> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Discount> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: discounttype.
        /// </summary>
        public static IEntityWrapper<DiscountType> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<DiscountType> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: displaystring.
        /// </summary>
        public static IEntityWrapper<DisplayString> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<DisplayString> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: email.
        /// </summary>
        public static IEntityWrapper<Email> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Email> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: emailserverprofile.
        /// </summary>
        public static IEntityWrapper<EmailServerProfile> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<EmailServerProfile> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlement.
        /// </summary>
        public static IEntityWrapper<Entitlement> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Entitlement> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlementchannel.
        /// </summary>
        public static IEntityWrapper<EntitlementChannel> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<EntitlementChannel> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlementtemplate.
        /// </summary>
        public static IEntityWrapper<EntitlementTemplate> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<EntitlementTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitymap.
        /// </summary>
        public static IEntityWrapper<EntityMap> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<EntityMap> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: equipment.
        /// </summary>
        public static IEntityWrapper<Equipment> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Equipment> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: externalpartyitem.
        /// </summary>
        public static IEntityWrapper<ExternalPartyItem> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<ExternalPartyItem> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: fax.
        /// </summary>
        public static IEntityWrapper<Fax> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Fax> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: fixedmonthlyfiscalcalendar.
        /// </summary>
        public static IEntityWrapper<FixedMonthlyFiscalCalendar> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<FixedMonthlyFiscalCalendar> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: import.
        /// </summary>
        public static IEntityWrapper<Import> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Import> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: importdata.
        /// </summary>
        public static IEntityWrapper<ImportData> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<ImportData> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: importfile.
        /// </summary>
        public static IEntityWrapper<ImportFile> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<ImportFile> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: importlog.
        /// </summary>
        public static IEntityWrapper<ImportLog> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<ImportLog> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: importmap.
        /// </summary>
        public static IEntityWrapper<ImportMap> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<ImportMap> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: incidentresolution.
        /// </summary>
        public static IEntityWrapper<IncidentResolution> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<IncidentResolution> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: ins_salesorder.
        /// </summary>
        public static IEntityWrapper<ins_salesorder> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<ins_salesorder> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: ins_salesorderline.
        /// </summary>
        public static IEntityWrapper<ins_salesorderline> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<ins_salesorderline> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: invoice.
        /// </summary>
        public static IEntityWrapper<Invoice> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Invoice> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: invoicedetail.
        /// </summary>
        public static IEntityWrapper<InvoiceDetail> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<InvoiceDetail> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: isvconfig.
        /// </summary>
        public static IEntityWrapper<IsvConfig> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<IsvConfig> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: kbarticle.
        /// </summary>
        public static IEntityWrapper<KbArticle> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<KbArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: kbarticlecomment.
        /// </summary>
        public static IEntityWrapper<KbArticleComment> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<KbArticleComment> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: kbarticletemplate.
        /// </summary>
        public static IEntityWrapper<KbArticleTemplate> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<KbArticleTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgebaserecord.
        /// </summary>
        public static IEntityWrapper<KnowledgeBaseRecord> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<KnowledgeBaseRecord> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: letter.
        /// </summary>
        public static IEntityWrapper<Letter> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Letter> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: list.
        /// </summary>
        public static IEntityWrapper<List> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<List> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: monthlyfiscalcalendar.
        /// </summary>
        public static IEntityWrapper<MonthlyFiscalCalendar> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<MonthlyFiscalCalendar> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_postalbum.
        /// </summary>
        public static IEntityWrapper<msdyn_PostAlbum> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<msdyn_PostAlbum> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_postconfig.
        /// </summary>
        public static IEntityWrapper<msdyn_PostConfig> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<msdyn_PostConfig> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_postruleconfig.
        /// </summary>
        public static IEntityWrapper<msdyn_PostRuleConfig> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<msdyn_PostRuleConfig> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_wallsavedquery.
        /// </summary>
        public static IEntityWrapper<msdyn_wallsavedquery> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<msdyn_wallsavedquery> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_wallsavedqueryusersettings.
        /// </summary>
        public static IEntityWrapper<msdyn_wallsavedqueryusersettings> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<msdyn_wallsavedqueryusersettings> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunityclose.
        /// </summary>
        public static IEntityWrapper<OpportunityClose> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<OpportunityClose> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunityproduct.
        /// </summary>
        public static IEntityWrapper<OpportunityProduct> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<OpportunityProduct> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: orderclose.
        /// </summary>
        public static IEntityWrapper<OrderClose> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<OrderClose> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: phonecall.
        /// </summary>
        public static IEntityWrapper<PhoneCall> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<PhoneCall> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: post.
        /// </summary>
        public static IEntityWrapper<Post> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Post> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: pricelevel.
        /// </summary>
        public static IEntityWrapper<PriceLevel> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<PriceLevel> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: privilege.
        /// </summary>
        public static IEntityWrapper<Privilege> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Privilege> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: productpricelevel.
        /// </summary>
        public static IEntityWrapper<ProductPriceLevel> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<ProductPriceLevel> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: productsubstitute.
        /// </summary>
        public static IEntityWrapper<ProductSubstitute> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<ProductSubstitute> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quarterlyfiscalcalendar.
        /// </summary>
        public static IEntityWrapper<QuarterlyFiscalCalendar> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<QuarterlyFiscalCalendar> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: queue.
        /// </summary>
        public static IEntityWrapper<Queue> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Queue> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: queueitem.
        /// </summary>
        public static IEntityWrapper<QueueItem> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<QueueItem> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quoteclose.
        /// </summary>
        public static IEntityWrapper<QuoteClose> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<QuoteClose> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quotedetail.
        /// </summary>
        public static IEntityWrapper<QuoteDetail> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<QuoteDetail> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: ratingmodel.
        /// </summary>
        public static IEntityWrapper<RatingModel> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<RatingModel> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: ratingvalue.
        /// </summary>
        public static IEntityWrapper<RatingValue> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<RatingValue> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: recurringappointmentmaster.
        /// </summary>
        public static IEntityWrapper<RecurringAppointmentMaster> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<RecurringAppointmentMaster> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: relationshiprole.
        /// </summary>
        public static IEntityWrapper<RelationshipRole> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<RelationshipRole> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: relationshiprolemap.
        /// </summary>
        public static IEntityWrapper<RelationshipRoleMap> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<RelationshipRoleMap> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: resource.
        /// </summary>
        public static IEntityWrapper<Resource> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Resource> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: resourcegroup.
        /// </summary>
        public static IEntityWrapper<ResourceGroup> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<ResourceGroup> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: resourcespec.
        /// </summary>
        public static IEntityWrapper<ResourceSpec> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<ResourceSpec> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: role.
        /// </summary>
        public static IEntityWrapper<Role> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Role> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: routingrule.
        /// </summary>
        public static IEntityWrapper<RoutingRule> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<RoutingRule> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: routingruleitem.
        /// </summary>
        public static IEntityWrapper<RoutingRuleItem> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<RoutingRuleItem> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesliterature.
        /// </summary>
        public static IEntityWrapper<SalesLiterature> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<SalesLiterature> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesliteratureitem.
        /// </summary>
        public static IEntityWrapper<SalesLiteratureItem> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<SalesLiteratureItem> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesorder.
        /// </summary>
        public static IEntityWrapper<SalesOrder> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<SalesOrder> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesorderdetail.
        /// </summary>
        public static IEntityWrapper<SalesOrderDetail> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<SalesOrderDetail> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: savedquery.
        /// </summary>
        public static IEntityWrapper<SavedQuery> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<SavedQuery> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: semiannualfiscalcalendar.
        /// </summary>
        public static IEntityWrapper<SemiAnnualFiscalCalendar> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<SemiAnnualFiscalCalendar> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: service.
        /// </summary>
        public static IEntityWrapper<Service> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Service> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: serviceappointment.
        /// </summary>
        public static IEntityWrapper<ServiceAppointment> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<ServiceAppointment> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: site.
        /// </summary>
        public static IEntityWrapper<Site> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Site> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: socialactivity.
        /// </summary>
        public static IEntityWrapper<SocialActivity> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<SocialActivity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: subject.
        /// </summary>
        public static IEntityWrapper<Subject> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Subject> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: systemform.
        /// </summary>
        public static IEntityWrapper<SystemForm> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<SystemForm> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: task.
        /// </summary>
        public static IEntityWrapper<Task> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Task> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: template.
        /// </summary>
        public static IEntityWrapper<Template> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Template> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: territory.
        /// </summary>
        public static IEntityWrapper<Territory> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Territory> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: theme.
        /// </summary>
        public static IEntityWrapper<Theme> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Theme> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: uom.
        /// </summary>
        public static IEntityWrapper<UoM> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<UoM> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: uomschedule.
        /// </summary>
        public static IEntityWrapper<UoMSchedule> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<UoMSchedule> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: userform.
        /// </summary>
        public static IEntityWrapper<UserForm> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<UserForm> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: usermapping.
        /// </summary>
        public static IEntityWrapper<UserMapping> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<UserMapping> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: userquery.
        /// </summary>
        public static IEntityWrapper<UserQuery> GetName(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<UserQuery> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: asyncoperationid. Lookup to entity: asyncoperation.
        /// </summary>
        public static IEntityWrapper<AsyncOperation> GetSystemJob(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<AsyncOperation> columnSet)
            => wrapper.GetRelated(e => e.AsyncOperationId, columnSet);
        /// <summary>
        /// Related attribute: bulkdeleteoperationid. Lookup to entity: bulkdeleteoperation.
        /// </summary>
        public static IEntityWrapper<BulkDeleteOperation> GetBulkDeleteOperationId(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<BulkDeleteOperation> columnSet)
            => wrapper.GetRelated(e => e.BulkDeleteOperationId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<BulkDeleteFailure> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);

    }
    public static class BulkDeleteOperationExt
    {
        /// <summary>
        /// Related attribute: asyncoperationid. Lookup to entity: asyncoperation.
        /// </summary>
        public static IEntityWrapper<AsyncOperation> GetSystemJob(this IEntityWrapperRelation<BulkDeleteOperation> wrapper, IColumnSet<AsyncOperation> columnSet)
            => wrapper.GetRelated(e => e.AsyncOperationId, columnSet);
        /// <summary>
        /// Related attribute: owningbusinessunit. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetOwningBusinessUnit(this IEntityWrapperRelation<BulkDeleteOperation> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.OwningBusinessUnit, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<BulkDeleteOperation> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedOnBehalfBy(this IEntityWrapperRelation<BulkDeleteOperation> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<BulkDeleteOperation> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedOnBehalfBy(this IEntityWrapperRelation<BulkDeleteOperation> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<BulkDeleteOperation> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<BulkDeleteOperation> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Related attribute: owninguser. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwningUser(this IEntityWrapperRelation<BulkDeleteOperation> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwningUser, columnSet);

    }
    public static class BulkOperationExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaignactivity.
        /// </summary>
        public static IEntityWrapper<CampaignActivity> GetImportFileName(this IEntityWrapperRelation<BulkOperation> wrapper, IColumnSet<CampaignActivity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: list.
        /// </summary>
        public static IEntityWrapper<List> GetImportFileName(this IEntityWrapperRelation<BulkOperation> wrapper, IColumnSet<List> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);

    }
    public static class BulkOperationLogExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: createdobjectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetCreatedObject(this IEntityWrapperRelation<BulkOperationLog> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.CreatedObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: createdobjectid. Lookup to entity: activitypointer.
        /// </summary>
        public static IEntityWrapper<ActivityPointer> GetCreatedObject(this IEntityWrapperRelation<BulkOperationLog> wrapper, IColumnSet<ActivityPointer> columnSet)
            => wrapper.GetRelated(e => e.CreatedObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: createdobjectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetCreatedObject(this IEntityWrapperRelation<BulkOperationLog> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.CreatedObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: createdobjectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetCreatedObject(this IEntityWrapperRelation<BulkOperationLog> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.CreatedObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: createdobjectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetCreatedObject(this IEntityWrapperRelation<BulkOperationLog> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.CreatedObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetCustomersExcluded(this IEntityWrapperRelation<BulkOperationLog> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetCustomersExcluded(this IEntityWrapperRelation<BulkOperationLog> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetCustomersExcluded(this IEntityWrapperRelation<BulkOperationLog> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: bulkoperationid. Lookup to entity: bulkoperation.
        /// </summary>
        public static IEntityWrapper<BulkOperation> GetBulkOperationNumber(this IEntityWrapperRelation<BulkOperationLog> wrapper, IColumnSet<BulkOperation> columnSet)
            => wrapper.GetRelated(e => e.BulkOperationId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<BulkOperationLog> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<BulkOperationLog> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);

    }
    public static class BusinessDataLocalizedLabelExt
    {

    }
    public static class BusinessProcessFlowInstanceExt
    {
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<BusinessProcessFlowInstance> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<BusinessProcessFlowInstance> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<BusinessProcessFlowInstance> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<BusinessProcessFlowInstance> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: processid. Lookup to entity: workflow.
        /// </summary>
        public static IEntityWrapper<Workflow> GetProcess(this IEntityWrapperRelation<BusinessProcessFlowInstance> wrapper, IColumnSet<Workflow> columnSet)
            => wrapper.GetRelated(e => e.ProcessId, columnSet);

    }
    public static class BusinessUnitExt
    {
        /// <summary>
        /// Related attribute: parentbusinessunitid. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetParentBusiness(this IEntityWrapperRelation<BusinessUnit> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.ParentBusinessUnitId, columnSet);
        /// <summary>
        /// Related attribute: calendarid. Lookup to entity: calendar.
        /// </summary>
        public static IEntityWrapper<Calendar> GetCalendar(this IEntityWrapperRelation<BusinessUnit> wrapper, IColumnSet<Calendar> columnSet)
            => wrapper.GetRelated(e => e.CalendarId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<BusinessUnit> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<BusinessUnit> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<BusinessUnit> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<BusinessUnit> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<BusinessUnit> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<BusinessUnit> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class BusinessUnitNewsArticleExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<BusinessUnitNewsArticle> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class CalendarExt
    {
        /// <summary>
        /// Related attribute: businessunitid. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetBusinessUnit(this IEntityWrapperRelation<Calendar> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.BusinessUnitId, columnSet);
        /// <summary>
        /// Related attribute: holidayschedulecalendarid. Lookup to entity: calendar.
        /// </summary>
        public static IEntityWrapper<Calendar> GetHolidayScheduleCalendarId(this IEntityWrapperRelation<Calendar> wrapper, IColumnSet<Calendar> columnSet)
            => wrapper.GetRelated(e => e.HolidayScheduleCalendarId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<Calendar> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<Calendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<Calendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<Calendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<Calendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);

    }
    public static class CalendarRuleExt
    {
        /// <summary>
        /// Related attribute: calendarid. Lookup to entity: calendar.
        /// </summary>
        public static IEntityWrapper<Calendar> GetCalendar(this IEntityWrapperRelation<CalendarRule> wrapper, IColumnSet<Calendar> columnSet)
            => wrapper.GetRelated(e => e.CalendarId, columnSet);
        /// <summary>
        /// Related attribute: innercalendarid. Lookup to entity: calendar.
        /// </summary>
        public static IEntityWrapper<Calendar> GetInnerCalendar(this IEntityWrapperRelation<CalendarRule> wrapper, IColumnSet<Calendar> columnSet)
            => wrapper.GetRelated(e => e.InnerCalendarId, columnSet);
        /// <summary>
        /// Related attribute: serviceid. Lookup to entity: service.
        /// </summary>
        public static IEntityWrapper<Service> GetService(this IEntityWrapperRelation<CalendarRule> wrapper, IColumnSet<Service> columnSet)
            => wrapper.GetRelated(e => e.ServiceId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<CalendarRule> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<CalendarRule> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<CalendarRule> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<CalendarRule> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);

    }
    public static class CampaignExt
    {
        /// <summary>
        /// Related attribute: pricelistid. Lookup to entity: pricelevel.
        /// </summary>
        public static IEntityWrapper<PriceLevel> GetPriceList(this IEntityWrapperRelation<Campaign> wrapper, IColumnSet<PriceLevel> columnSet)
            => wrapper.GetRelated(e => e.PriceListId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Campaign> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class CampaignActivityExt
    {
        /// <summary>
        /// Related attribute: regardingobjectid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetParentCampaign(this IEntityWrapperRelation<CampaignActivity> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<CampaignActivity> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class CampaignActivityItemExt
    {
        /// <summary>
        /// Related attribute: campaignactivityid. Lookup to entity: campaignactivity.
        /// </summary>
        public static IEntityWrapper<CampaignActivity> GetCampaignActivityId(this IEntityWrapperRelation<CampaignActivityItem> wrapper, IColumnSet<CampaignActivity> columnSet)
            => wrapper.GetRelated(e => e.CampaignActivityId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<CampaignActivityItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<CampaignActivityItem> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);

    }
    public static class CampaignItemExt
    {
        /// <summary>
        /// Related attribute: campaignid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetCampaignId(this IEntityWrapperRelation<CampaignItem> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.CampaignId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<CampaignItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<CampaignItem> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);

    }
    public static class CampaignResponseExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: originatingactivityid. Lookup to entity: appointment.
        /// </summary>
        public static IEntityWrapper<Appointment> GetOriginatingActivity(this IEntityWrapperRelation<CampaignResponse> wrapper, IColumnSet<Appointment> columnSet)
            => wrapper.GetRelated(e => e.OriginatingActivityId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: originatingactivityid. Lookup to entity: email.
        /// </summary>
        public static IEntityWrapper<Email> GetOriginatingActivity(this IEntityWrapperRelation<CampaignResponse> wrapper, IColumnSet<Email> columnSet)
            => wrapper.GetRelated(e => e.OriginatingActivityId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: originatingactivityid. Lookup to entity: fax.
        /// </summary>
        public static IEntityWrapper<Fax> GetOriginatingActivity(this IEntityWrapperRelation<CampaignResponse> wrapper, IColumnSet<Fax> columnSet)
            => wrapper.GetRelated(e => e.OriginatingActivityId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: originatingactivityid. Lookup to entity: letter.
        /// </summary>
        public static IEntityWrapper<Letter> GetOriginatingActivity(this IEntityWrapperRelation<CampaignResponse> wrapper, IColumnSet<Letter> columnSet)
            => wrapper.GetRelated(e => e.OriginatingActivityId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: originatingactivityid. Lookup to entity: phonecall.
        /// </summary>
        public static IEntityWrapper<PhoneCall> GetOriginatingActivity(this IEntityWrapperRelation<CampaignResponse> wrapper, IColumnSet<PhoneCall> columnSet)
            => wrapper.GetRelated(e => e.OriginatingActivityId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bulkoperation.
        /// </summary>
        public static IEntityWrapper<BulkOperation> GetParentCampaign(this IEntityWrapperRelation<CampaignResponse> wrapper, IColumnSet<BulkOperation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetParentCampaign(this IEntityWrapperRelation<CampaignResponse> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<CampaignResponse> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class CardTypeExt
    {
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<CardType> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<CardType> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<CardType> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<CardType> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<CardType> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class CategoryExt
    {
        /// <summary>
        /// Related attribute: parentcategoryid. Lookup to entity: category.
        /// </summary>
        public static IEntityWrapper<Category> GetParentCategory(this IEntityWrapperRelation<Category> wrapper, IColumnSet<Category> columnSet)
            => wrapper.GetRelated(e => e.ParentCategoryId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Category> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class ChannelAccessProfileExt
    {
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<ChannelAccessProfile> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class ChannelAccessProfileRuleExt
    {
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<ChannelAccessProfileRule> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);
        /// <summary>
        /// Related attribute: workflowid. Lookup to entity: workflow.
        /// </summary>
        public static IEntityWrapper<Workflow> GetWorkflow(this IEntityWrapperRelation<ChannelAccessProfileRule> wrapper, IColumnSet<Workflow> columnSet)
            => wrapper.GetRelated(e => e.WorkflowId, columnSet);

    }
    public static class ChannelAccessProfileRuleItemExt
    {
        /// <summary>
        /// Related attribute: associatedchannelaccessprofile. Lookup to entity: channelaccessprofile.
        /// </summary>
        public static IEntityWrapper<ChannelAccessProfile> GetAssignProfile(this IEntityWrapperRelation<ChannelAccessProfileRuleItem> wrapper, IColumnSet<ChannelAccessProfile> columnSet)
            => wrapper.GetRelated(e => e.AssociatedChannelAccessProfile, columnSet);
        /// <summary>
        /// Related attribute: channelaccessprofileruleid. Lookup to entity: channelaccessprofilerule.
        /// </summary>
        public static IEntityWrapper<ChannelAccessProfileRule> GetChannelAccessProfileRule(this IEntityWrapperRelation<ChannelAccessProfileRuleItem> wrapper, IColumnSet<ChannelAccessProfileRule> columnSet)
            => wrapper.GetRelated(e => e.ChannelAccessProfileRuleId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<ChannelAccessProfileRuleItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<ChannelAccessProfileRuleItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<ChannelAccessProfileRuleItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<ChannelAccessProfileRuleItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<ChannelAccessProfileRuleItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<ChannelAccessProfileRuleItem> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<ChannelAccessProfileRuleItem> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class ChannelPropertyExt
    {
        /// <summary>
        /// Related attribute: regardingobjectid. Lookup to entity: channelpropertygroup.
        /// </summary>
        public static IEntityWrapper<ChannelPropertyGroup> GetRegarding(this IEntityWrapperRelation<ChannelProperty> wrapper, IColumnSet<ChannelPropertyGroup> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<ChannelProperty> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class ChannelPropertyGroupExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<ChannelPropertyGroup> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class CharacteristicExt
    {
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Characteristic> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class ColumnMappingExt
    {
        /// <summary>
        /// Related attribute: importmapid. Lookup to entity: importmap.
        /// </summary>
        public static IEntityWrapper<ImportMap> GetDataMapID(this IEntityWrapperRelation<ColumnMapping> wrapper, IColumnSet<ImportMap> columnSet)
            => wrapper.GetRelated(e => e.ImportMapId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<ColumnMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<ColumnMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<ColumnMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<ColumnMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);

    }
    public static class CommitmentExt
    {

    }
    public static class CompetitorExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<Competitor> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Competitor> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class CompetitorAddressExt
    {
        /// <summary>
        /// Related attribute: parentid. Lookup to entity: competitor.
        /// </summary>
        public static IEntityWrapper<Competitor> GetParent(this IEntityWrapperRelation<CompetitorAddress> wrapper, IColumnSet<Competitor> columnSet)
            => wrapper.GetRelated(e => e.ParentId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<CompetitorAddress> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<CompetitorAddress> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<CompetitorAddress> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<CompetitorAddress> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);

    }
    public static class ComplexControlExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<ComplexControl> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class ConnectionExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: activitypointer.
        /// </summary>
        public static IEntityWrapper<ActivityPointer> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<ActivityPointer> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: appointment.
        /// </summary>
        public static IEntityWrapper<Appointment> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Appointment> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: campaignactivity.
        /// </summary>
        public static IEntityWrapper<CampaignActivity> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<CampaignActivity> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: channelaccessprofilerule.
        /// </summary>
        public static IEntityWrapper<ChannelAccessProfileRule> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<ChannelAccessProfileRule> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: competitor.
        /// </summary>
        public static IEntityWrapper<Competitor> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Competitor> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: constraintbasedgroup.
        /// </summary>
        public static IEntityWrapper<ConstraintBasedGroup> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<ConstraintBasedGroup> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: email.
        /// </summary>
        public static IEntityWrapper<Email> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Email> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: entitlement.
        /// </summary>
        public static IEntityWrapper<Entitlement> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Entitlement> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: equipment.
        /// </summary>
        public static IEntityWrapper<Equipment> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Equipment> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: fax.
        /// </summary>
        public static IEntityWrapper<Fax> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Fax> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: goal.
        /// </summary>
        public static IEntityWrapper<Goal> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Goal> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: invoice.
        /// </summary>
        public static IEntityWrapper<Invoice> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Invoice> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: knowledgebaserecord.
        /// </summary>
        public static IEntityWrapper<KnowledgeBaseRecord> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<KnowledgeBaseRecord> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: letter.
        /// </summary>
        public static IEntityWrapper<Letter> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Letter> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: list.
        /// </summary>
        public static IEntityWrapper<List> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<List> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: msdyn_postalbum.
        /// </summary>
        public static IEntityWrapper<msdyn_PostAlbum> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<msdyn_PostAlbum> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: phonecall.
        /// </summary>
        public static IEntityWrapper<PhoneCall> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<PhoneCall> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: position.
        /// </summary>
        public static IEntityWrapper<Position> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Position> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: pricelevel.
        /// </summary>
        public static IEntityWrapper<PriceLevel> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<PriceLevel> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: processsession.
        /// </summary>
        public static IEntityWrapper<ProcessSession> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<ProcessSession> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: recurringappointmentmaster.
        /// </summary>
        public static IEntityWrapper<RecurringAppointmentMaster> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<RecurringAppointmentMaster> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: resourcegroup.
        /// </summary>
        public static IEntityWrapper<ResourceGroup> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<ResourceGroup> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: salesorder.
        /// </summary>
        public static IEntityWrapper<SalesOrder> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<SalesOrder> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: serviceappointment.
        /// </summary>
        public static IEntityWrapper<ServiceAppointment> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<ServiceAppointment> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: socialactivity.
        /// </summary>
        public static IEntityWrapper<SocialActivity> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<SocialActivity> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: socialprofile.
        /// </summary>
        public static IEntityWrapper<SocialProfile> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<SocialProfile> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: task.
        /// </summary>
        public static IEntityWrapper<Task> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Task> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record1id. Lookup to entity: territory.
        /// </summary>
        public static IEntityWrapper<Territory> GetConnectedFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Territory> columnSet)
            => wrapper.GetRelated(e => e.Record1Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: activitypointer.
        /// </summary>
        public static IEntityWrapper<ActivityPointer> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<ActivityPointer> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: appointment.
        /// </summary>
        public static IEntityWrapper<Appointment> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Appointment> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: campaignactivity.
        /// </summary>
        public static IEntityWrapper<CampaignActivity> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<CampaignActivity> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: channelaccessprofilerule.
        /// </summary>
        public static IEntityWrapper<ChannelAccessProfileRule> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<ChannelAccessProfileRule> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: competitor.
        /// </summary>
        public static IEntityWrapper<Competitor> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Competitor> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: constraintbasedgroup.
        /// </summary>
        public static IEntityWrapper<ConstraintBasedGroup> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<ConstraintBasedGroup> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: email.
        /// </summary>
        public static IEntityWrapper<Email> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Email> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: entitlement.
        /// </summary>
        public static IEntityWrapper<Entitlement> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Entitlement> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: equipment.
        /// </summary>
        public static IEntityWrapper<Equipment> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Equipment> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: fax.
        /// </summary>
        public static IEntityWrapper<Fax> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Fax> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: goal.
        /// </summary>
        public static IEntityWrapper<Goal> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Goal> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: invoice.
        /// </summary>
        public static IEntityWrapper<Invoice> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Invoice> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: knowledgebaserecord.
        /// </summary>
        public static IEntityWrapper<KnowledgeBaseRecord> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<KnowledgeBaseRecord> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: letter.
        /// </summary>
        public static IEntityWrapper<Letter> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Letter> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: list.
        /// </summary>
        public static IEntityWrapper<List> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<List> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: msdyn_postalbum.
        /// </summary>
        public static IEntityWrapper<msdyn_PostAlbum> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<msdyn_PostAlbum> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: phonecall.
        /// </summary>
        public static IEntityWrapper<PhoneCall> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<PhoneCall> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: position.
        /// </summary>
        public static IEntityWrapper<Position> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Position> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: pricelevel.
        /// </summary>
        public static IEntityWrapper<PriceLevel> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<PriceLevel> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: processsession.
        /// </summary>
        public static IEntityWrapper<ProcessSession> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<ProcessSession> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: recurringappointmentmaster.
        /// </summary>
        public static IEntityWrapper<RecurringAppointmentMaster> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<RecurringAppointmentMaster> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: resourcegroup.
        /// </summary>
        public static IEntityWrapper<ResourceGroup> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<ResourceGroup> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: salesorder.
        /// </summary>
        public static IEntityWrapper<SalesOrder> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<SalesOrder> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: serviceappointment.
        /// </summary>
        public static IEntityWrapper<ServiceAppointment> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<ServiceAppointment> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: socialactivity.
        /// </summary>
        public static IEntityWrapper<SocialActivity> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<SocialActivity> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: socialprofile.
        /// </summary>
        public static IEntityWrapper<SocialProfile> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<SocialProfile> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: task.
        /// </summary>
        public static IEntityWrapper<Task> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Task> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: record2id. Lookup to entity: territory.
        /// </summary>
        public static IEntityWrapper<Territory> GetConnectedTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Territory> columnSet)
            => wrapper.GetRelated(e => e.Record2Id, columnSet);
        /// <summary>
        /// Related attribute: relatedconnectionid. Lookup to entity: connection.
        /// </summary>
        public static IEntityWrapper<Connection> GetReciprocalConnection(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<Connection> columnSet)
            => wrapper.GetRelated(e => e.RelatedConnectionId, columnSet);
        /// <summary>
        /// Related attribute: record1roleid. Lookup to entity: connectionrole.
        /// </summary>
        public static IEntityWrapper<ConnectionRole> GetRoleFrom(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<ConnectionRole> columnSet)
            => wrapper.GetRelated(e => e.Record1RoleId, columnSet);
        /// <summary>
        /// Related attribute: record2roleid. Lookup to entity: connectionrole.
        /// </summary>
        public static IEntityWrapper<ConnectionRole> GetRoleTo(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<ConnectionRole> columnSet)
            => wrapper.GetRelated(e => e.Record2RoleId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Connection> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class ConnectionRoleExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<ConnectionRole> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class ConnectionRoleObjectTypeCodeExt
    {
        /// <summary>
        /// Related attribute: connectionroleid. Lookup to entity: connectionrole.
        /// </summary>
        public static IEntityWrapper<ConnectionRole> GetConnectionRole(this IEntityWrapperRelation<ConnectionRoleObjectTypeCode> wrapper, IColumnSet<ConnectionRole> columnSet)
            => wrapper.GetRelated(e => e.ConnectionRoleId, columnSet);

    }
    public static class ConstraintBasedGroupExt
    {
        /// <summary>
        /// Related attribute: businessunitid. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetBusinessUnit(this IEntityWrapperRelation<ConstraintBasedGroup> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.BusinessUnitId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<ConstraintBasedGroup> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<ConstraintBasedGroup> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<ConstraintBasedGroup> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<ConstraintBasedGroup> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<ConstraintBasedGroup> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);

    }
    public static class ContactExt
    {
        /// <summary>
        /// Related attribute: accountid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetAccount(this IEntityWrapperRelation<Contact> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.AccountId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: parentcustomerid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetCompanyName(this IEntityWrapperRelation<Contact> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.ParentCustomerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: parentcustomerid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetCompanyName(this IEntityWrapperRelation<Contact> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.ParentCustomerId, columnSet);
        /// <summary>
        /// Related attribute: masterid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetMasterID(this IEntityWrapperRelation<Contact> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.MasterId, columnSet);
        /// <summary>
        /// Related attribute: parentcontactid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetParentContact(this IEntityWrapperRelation<Contact> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.ParentContactId, columnSet);
        /// <summary>
        /// Related attribute: preferredequipmentid. Lookup to entity: equipment.
        /// </summary>
        public static IEntityWrapper<Equipment> GetPreferredFacilityEquipment(this IEntityWrapperRelation<Contact> wrapper, IColumnSet<Equipment> columnSet)
            => wrapper.GetRelated(e => e.PreferredEquipmentId, columnSet);
        /// <summary>
        /// Related attribute: createdbyexternalparty. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetCreatedByExternalParty(this IEntityWrapperRelation<Contact> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.CreatedByExternalParty, columnSet);
        /// <summary>
        /// Related attribute: modifiedbyexternalparty. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetModifiedByExternalParty(this IEntityWrapperRelation<Contact> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.ModifiedByExternalParty, columnSet);
        /// <summary>
        /// Related attribute: originatingleadid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetOriginatingLead(this IEntityWrapperRelation<Contact> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.OriginatingLeadId, columnSet);
        /// <summary>
        /// Related attribute: defaultpricelevelid. Lookup to entity: pricelevel.
        /// </summary>
        public static IEntityWrapper<PriceLevel> GetPriceList(this IEntityWrapperRelation<Contact> wrapper, IColumnSet<PriceLevel> columnSet)
            => wrapper.GetRelated(e => e.DefaultPriceLevelId, columnSet);
        /// <summary>
        /// Related attribute: preferredserviceid. Lookup to entity: service.
        /// </summary>
        public static IEntityWrapper<Service> GetPreferredService(this IEntityWrapperRelation<Contact> wrapper, IColumnSet<Service> columnSet)
            => wrapper.GetRelated(e => e.PreferredServiceId, columnSet);
        /// <summary>
        /// Related attribute: slaid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetSLA(this IEntityWrapperRelation<Contact> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAId, columnSet);
        /// <summary>
        /// Related attribute: slainvokedid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetLastSLAApplied(this IEntityWrapperRelation<Contact> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAInvokedId, columnSet);
        /// <summary>
        /// Related attribute: preferredsystemuserid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetPreferredUser(this IEntityWrapperRelation<Contact> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.PreferredSystemUserId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Contact> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class ContractExt
    {
        /// <summary>
        /// Related attribute: accountid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetAccount(this IEntityWrapperRelation<Contract> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.AccountId, columnSet);
        /// <summary>
        /// Related attribute: billingaccountid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetBillingAccount(this IEntityWrapperRelation<Contract> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.BillingAccountId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: billingcustomerid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetBillToCustomer(this IEntityWrapperRelation<Contract> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.BillingCustomerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: billingcustomerid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetBillToCustomer(this IEntityWrapperRelation<Contract> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.BillingCustomerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: customerid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetCustomer(this IEntityWrapperRelation<Contract> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.CustomerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: customerid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetCustomer(this IEntityWrapperRelation<Contract> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.CustomerId, columnSet);
        /// <summary>
        /// Related attribute: billingcontactid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetBillingContact(this IEntityWrapperRelation<Contract> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.BillingContactId, columnSet);
        /// <summary>
        /// Related attribute: contactid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetContact(this IEntityWrapperRelation<Contract> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.ContactId, columnSet);
        /// <summary>
        /// Related attribute: originatingcontract. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetOriginatingContract(this IEntityWrapperRelation<Contract> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.OriginatingContract, columnSet);
        /// <summary>
        /// Related attribute: contracttemplateid. Lookup to entity: contracttemplate.
        /// </summary>
        public static IEntityWrapper<ContractTemplate> GetContractTemplate(this IEntityWrapperRelation<Contract> wrapper, IColumnSet<ContractTemplate> columnSet)
            => wrapper.GetRelated(e => e.ContractTemplateId, columnSet);
        /// <summary>
        /// Related attribute: billtoaddress. Lookup to entity: customeraddress.
        /// </summary>
        public static IEntityWrapper<CustomerAddress> GetBillToAddress(this IEntityWrapperRelation<Contract> wrapper, IColumnSet<CustomerAddress> columnSet)
            => wrapper.GetRelated(e => e.BillToAddress, columnSet);
        /// <summary>
        /// Related attribute: serviceaddress. Lookup to entity: customeraddress.
        /// </summary>
        public static IEntityWrapper<CustomerAddress> GetContractAddress(this IEntityWrapperRelation<Contract> wrapper, IColumnSet<CustomerAddress> columnSet)
            => wrapper.GetRelated(e => e.ServiceAddress, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Contract> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class ContractDetailExt
    {
        /// <summary>
        /// Related attribute: accountid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetAccount(this IEntityWrapperRelation<ContractDetail> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.AccountId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: customerid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetCustomer(this IEntityWrapperRelation<ContractDetail> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.CustomerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: customerid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetCustomer(this IEntityWrapperRelation<ContractDetail> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.CustomerId, columnSet);
        /// <summary>
        /// Related attribute: contactid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetContact(this IEntityWrapperRelation<ContractDetail> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.ContactId, columnSet);
        /// <summary>
        /// Related attribute: contractid. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetContract(this IEntityWrapperRelation<ContractDetail> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.ContractId, columnSet);
        /// <summary>
        /// Related attribute: serviceaddress. Lookup to entity: customeraddress.
        /// </summary>
        public static IEntityWrapper<CustomerAddress> GetLocation(this IEntityWrapperRelation<ContractDetail> wrapper, IColumnSet<CustomerAddress> columnSet)
            => wrapper.GetRelated(e => e.ServiceAddress, columnSet);
        /// <summary>
        /// Related attribute: productid. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetProduct(this IEntityWrapperRelation<ContractDetail> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.ProductId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<ContractDetail> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<ContractDetail> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<ContractDetail> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<ContractDetail> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<ContractDetail> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<ContractDetail> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<ContractDetail> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);
        /// <summary>
        /// Related attribute: uomid. Lookup to entity: uom.
        /// </summary>
        public static IEntityWrapper<UoM> GetUnit(this IEntityWrapperRelation<ContractDetail> wrapper, IColumnSet<UoM> columnSet)
            => wrapper.GetRelated(e => e.UoMId, columnSet);
        /// <summary>
        /// Related attribute: uomscheduleid. Lookup to entity: uomschedule.
        /// </summary>
        public static IEntityWrapper<UoMSchedule> GetUnitSchedule(this IEntityWrapperRelation<ContractDetail> wrapper, IColumnSet<UoMSchedule> columnSet)
            => wrapper.GetRelated(e => e.UoMScheduleId, columnSet);

    }
    public static class ContractTemplateExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<ContractTemplate> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class ConvertRuleExt
    {
        /// <summary>
        /// Related attribute: channelpropertygroupid. Lookup to entity: channelpropertygroup.
        /// </summary>
        public static IEntityWrapper<ChannelPropertyGroup> GetChannelPropertyGroup(this IEntityWrapperRelation<ConvertRule> wrapper, IColumnSet<ChannelPropertyGroup> columnSet)
            => wrapper.GetRelated(e => e.ChannelPropertyGroupId, columnSet);
        /// <summary>
        /// Related attribute: queueid. Lookup to entity: queue.
        /// </summary>
        public static IEntityWrapper<Queue> GetQueue(this IEntityWrapperRelation<ConvertRule> wrapper, IColumnSet<Queue> columnSet)
            => wrapper.GetRelated(e => e.QueueId, columnSet);
        /// <summary>
        /// Related attribute: responsetemplateid. Lookup to entity: template.
        /// </summary>
        public static IEntityWrapper<Template> GetResponseEmailTemplate(this IEntityWrapperRelation<ConvertRule> wrapper, IColumnSet<Template> columnSet)
            => wrapper.GetRelated(e => e.ResponseTemplateId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<ConvertRule> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);
        /// <summary>
        /// Related attribute: workflowid. Lookup to entity: workflow.
        /// </summary>
        public static IEntityWrapper<Workflow> GetWorkflow(this IEntityWrapperRelation<ConvertRule> wrapper, IColumnSet<Workflow> columnSet)
            => wrapper.GetRelated(e => e.WorkflowId, columnSet);

    }
    public static class ConvertRuleItemExt
    {
        /// <summary>
        /// Related attribute: owningbusinessunit. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetOwningBusinessUnit(this IEntityWrapperRelation<ConvertRuleItem> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.OwningBusinessUnit, columnSet);
        /// <summary>
        /// Related attribute: convertruleid. Lookup to entity: convertrule.
        /// </summary>
        public static IEntityWrapper<ConvertRule> GetShowTheConversionRuleAssociatedToThisRuleItem(this IEntityWrapperRelation<ConvertRuleItem> wrapper, IColumnSet<ConvertRule> columnSet)
            => wrapper.GetRelated(e => e.ConvertRuleId, columnSet);
        /// <summary>
        /// Related attribute: queueid. Lookup to entity: queue.
        /// </summary>
        public static IEntityWrapper<Queue> GetQueue(this IEntityWrapperRelation<ConvertRuleItem> wrapper, IColumnSet<Queue> columnSet)
            => wrapper.GetRelated(e => e.QueueId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<ConvertRuleItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<ConvertRuleItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<ConvertRuleItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<ConvertRuleItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<ConvertRuleItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<ConvertRuleItem> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Related attribute: owninguser. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwningUser(this IEntityWrapperRelation<ConvertRuleItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwningUser, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<ConvertRuleItem> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);
        /// <summary>
        /// Related attribute: conditionid. Lookup to entity: workflow.
        /// </summary>
        public static IEntityWrapper<Workflow> GetCondition(this IEntityWrapperRelation<ConvertRuleItem> wrapper, IColumnSet<Workflow> columnSet)
            => wrapper.GetRelated(e => e.ConditionId, columnSet);
        /// <summary>
        /// Related attribute: workflowid. Lookup to entity: workflow.
        /// </summary>
        public static IEntityWrapper<Workflow> GetWorkflowID(this IEntityWrapperRelation<ConvertRuleItem> wrapper, IColumnSet<Workflow> columnSet)
            => wrapper.GetRelated(e => e.WorkflowId, columnSet);

    }
    public static class CustomControlExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<CustomControl> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class CustomControlDefaultConfigExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<CustomControlDefaultConfig> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class CustomControlResourceExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<CustomControlResource> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class CustomerAddressExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: parentid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetParent(this IEntityWrapperRelation<CustomerAddress> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.ParentId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: parentid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetParent(this IEntityWrapperRelation<CustomerAddress> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.ParentId, columnSet);
        /// <summary>
        /// Related attribute: owningbusinessunit. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetOwningBusinessUnit(this IEntityWrapperRelation<CustomerAddress> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.OwningBusinessUnit, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<CustomerAddress> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<CustomerAddress> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<CustomerAddress> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<CustomerAddress> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<CustomerAddress> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<CustomerAddress> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Related attribute: owninguser. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwnerUser(this IEntityWrapperRelation<CustomerAddress> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwningUser, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<CustomerAddress> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class CustomerOpportunityRoleExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: customerid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetCustomer(this IEntityWrapperRelation<CustomerOpportunityRole> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.CustomerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: customerid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetCustomer(this IEntityWrapperRelation<CustomerOpportunityRole> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.CustomerId, columnSet);
        /// <summary>
        /// Related attribute: opportunityid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetOpportunity(this IEntityWrapperRelation<CustomerOpportunityRole> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.OpportunityId, columnSet);
        /// <summary>
        /// Related attribute: opportunityroleid. Lookup to entity: relationshiprole.
        /// </summary>
        public static IEntityWrapper<RelationshipRole> GetCustomerRole(this IEntityWrapperRelation<CustomerOpportunityRole> wrapper, IColumnSet<RelationshipRole> columnSet)
            => wrapper.GetRelated(e => e.OpportunityRoleId, columnSet);

    }
    public static class CustomerRelationshipExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: customerid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetParty1(this IEntityWrapperRelation<CustomerRelationship> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.CustomerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: customerid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetParty1(this IEntityWrapperRelation<CustomerRelationship> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.CustomerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: partnerid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetParty2(this IEntityWrapperRelation<CustomerRelationship> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.PartnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: partnerid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetParty2(this IEntityWrapperRelation<CustomerRelationship> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.PartnerId, columnSet);
        /// <summary>
        /// Related attribute: converserelationshipid. Lookup to entity: customerrelationship.
        /// </summary>
        public static IEntityWrapper<CustomerRelationship> GetConverseRelationship(this IEntityWrapperRelation<CustomerRelationship> wrapper, IColumnSet<CustomerRelationship> columnSet)
            => wrapper.GetRelated(e => e.ConverseRelationshipId, columnSet);
        /// <summary>
        /// Related attribute: customerroleid. Lookup to entity: relationshiprole.
        /// </summary>
        public static IEntityWrapper<RelationshipRole> GetRole1(this IEntityWrapperRelation<CustomerRelationship> wrapper, IColumnSet<RelationshipRole> columnSet)
            => wrapper.GetRelated(e => e.CustomerRoleId, columnSet);
        /// <summary>
        /// Related attribute: partnerroleid. Lookup to entity: relationshiprole.
        /// </summary>
        public static IEntityWrapper<RelationshipRole> GetRole2(this IEntityWrapperRelation<CustomerRelationship> wrapper, IColumnSet<RelationshipRole> columnSet)
            => wrapper.GetRelated(e => e.PartnerRoleId, columnSet);

    }
    public static class DataPerformanceExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<DataPerformance> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class DelveActionHubExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<DelveActionHub> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<DelveActionHub> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class DependencyExt
    {
        /// <summary>
        /// Related attribute: dependentcomponentnodeid. Lookup to entity: dependencynode.
        /// </summary>
        public static IEntityWrapper<DependencyNode> GetDependentComponent(this IEntityWrapperRelation<Dependency> wrapper, IColumnSet<DependencyNode> columnSet)
            => wrapper.GetRelated(e => e.DependentComponentNodeId, columnSet);
        /// <summary>
        /// Related attribute: requiredcomponentnodeid. Lookup to entity: dependencynode.
        /// </summary>
        public static IEntityWrapper<DependencyNode> GetRequiredComponent(this IEntityWrapperRelation<Dependency> wrapper, IColumnSet<DependencyNode> columnSet)
            => wrapper.GetRelated(e => e.RequiredComponentNodeId, columnSet);

    }
    public static class DependencyNodeExt
    {
        /// <summary>
        /// Related attribute: basesolutionid. Lookup to entity: solution.
        /// </summary>
        public static IEntityWrapper<Solution> GetBaseSolution(this IEntityWrapperRelation<DependencyNode> wrapper, IColumnSet<Solution> columnSet)
            => wrapper.GetRelated(e => e.BaseSolutionId, columnSet);
        /// <summary>
        /// Related attribute: topsolutionid. Lookup to entity: solution.
        /// </summary>
        public static IEntityWrapper<Solution> GetTopSolution(this IEntityWrapperRelation<DependencyNode> wrapper, IColumnSet<Solution> columnSet)
            => wrapper.GetRelated(e => e.TopSolutionId, columnSet);

    }
    public static class DiscountExt
    {
        /// <summary>
        /// Related attribute: discounttypeid. Lookup to entity: discounttype.
        /// </summary>
        public static IEntityWrapper<DiscountType> GetDiscountType(this IEntityWrapperRelation<Discount> wrapper, IColumnSet<DiscountType> columnSet)
            => wrapper.GetRelated(e => e.DiscountTypeId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<Discount> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<Discount> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<Discount> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<Discount> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Discount> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class DiscountTypeExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<DiscountType> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<DiscountType> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class DisplayStringExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<DisplayString> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class DocumentIndexExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: documentid. Lookup to entity: kbarticle.
        /// </summary>
        public static IEntityWrapper<KbArticle> GetDocument(this IEntityWrapperRelation<DocumentIndex> wrapper, IColumnSet<KbArticle> columnSet)
            => wrapper.GetRelated(e => e.DocumentId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: documentid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetDocument(this IEntityWrapperRelation<DocumentIndex> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.DocumentId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<DocumentIndex> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: subjectid. Lookup to entity: subject.
        /// </summary>
        public static IEntityWrapper<Subject> GetSubject(this IEntityWrapperRelation<DocumentIndex> wrapper, IColumnSet<Subject> columnSet)
            => wrapper.GetRelated(e => e.SubjectId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<DocumentIndex> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<DocumentIndex> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<DocumentIndex> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<DocumentIndex> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);

    }
    public static class DocumentTemplateExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<DocumentTemplate> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class DuplicateRecordExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: appointment.
        /// </summary>
        public static IEntityWrapper<Appointment> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Appointment> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: bookableresource.
        /// </summary>
        public static IEntityWrapper<BookableResource> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<BookableResource> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: bookableresourcebooking.
        /// </summary>
        public static IEntityWrapper<BookableResourceBooking> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<BookableResourceBooking> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: bookableresourcebookingheader.
        /// </summary>
        public static IEntityWrapper<BookableResourceBookingHeader> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<BookableResourceBookingHeader> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: bookableresourcecategory.
        /// </summary>
        public static IEntityWrapper<BookableResourceCategory> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<BookableResourceCategory> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: bookableresourcecategoryassn.
        /// </summary>
        public static IEntityWrapper<BookableResourceCategoryAssn> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<BookableResourceCategoryAssn> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: bookableresourcecharacteristic.
        /// </summary>
        public static IEntityWrapper<BookableResourceCharacteristic> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<BookableResourceCharacteristic> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: bookableresourcegroup.
        /// </summary>
        public static IEntityWrapper<BookableResourceGroup> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<BookableResourceGroup> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: bookingstatus.
        /// </summary>
        public static IEntityWrapper<BookingStatus> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<BookingStatus> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: campaignresponse.
        /// </summary>
        public static IEntityWrapper<CampaignResponse> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<CampaignResponse> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: channelaccessprofile.
        /// </summary>
        public static IEntityWrapper<ChannelAccessProfile> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<ChannelAccessProfile> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: characteristic.
        /// </summary>
        public static IEntityWrapper<Characteristic> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Characteristic> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: competitor.
        /// </summary>
        public static IEntityWrapper<Competitor> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Competitor> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: email.
        /// </summary>
        public static IEntityWrapper<Email> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Email> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: emailserverprofile.
        /// </summary>
        public static IEntityWrapper<EmailServerProfile> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<EmailServerProfile> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: entitlement.
        /// </summary>
        public static IEntityWrapper<Entitlement> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Entitlement> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: entitlementchannel.
        /// </summary>
        public static IEntityWrapper<EntitlementChannel> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<EntitlementChannel> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: entitlementtemplate.
        /// </summary>
        public static IEntityWrapper<EntitlementTemplate> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<EntitlementTemplate> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: equipment.
        /// </summary>
        public static IEntityWrapper<Equipment> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Equipment> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: fax.
        /// </summary>
        public static IEntityWrapper<Fax> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Fax> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: goal.
        /// </summary>
        public static IEntityWrapper<Goal> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Goal> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: goalrollupquery.
        /// </summary>
        public static IEntityWrapper<GoalRollupQuery> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<GoalRollupQuery> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: ins_salesorder.
        /// </summary>
        public static IEntityWrapper<ins_salesorder> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<ins_salesorder> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: ins_salesorderline.
        /// </summary>
        public static IEntityWrapper<ins_salesorderline> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<ins_salesorderline> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: kbarticle.
        /// </summary>
        public static IEntityWrapper<KbArticle> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<KbArticle> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: knowledgebaserecord.
        /// </summary>
        public static IEntityWrapper<KnowledgeBaseRecord> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<KnowledgeBaseRecord> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: letter.
        /// </summary>
        public static IEntityWrapper<Letter> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Letter> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: list.
        /// </summary>
        public static IEntityWrapper<List> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<List> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: msdyn_postalbum.
        /// </summary>
        public static IEntityWrapper<msdyn_PostAlbum> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<msdyn_PostAlbum> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: phonecall.
        /// </summary>
        public static IEntityWrapper<PhoneCall> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<PhoneCall> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: publisher.
        /// </summary>
        public static IEntityWrapper<Publisher> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Publisher> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: queue.
        /// </summary>
        public static IEntityWrapper<Queue> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Queue> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: ratingmodel.
        /// </summary>
        public static IEntityWrapper<RatingModel> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<RatingModel> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: ratingvalue.
        /// </summary>
        public static IEntityWrapper<RatingValue> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<RatingValue> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: recurringappointmentmaster.
        /// </summary>
        public static IEntityWrapper<RecurringAppointmentMaster> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<RecurringAppointmentMaster> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: resourcegroup.
        /// </summary>
        public static IEntityWrapper<ResourceGroup> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<ResourceGroup> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: service.
        /// </summary>
        public static IEntityWrapper<Service> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Service> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: sharepointdocumentlocation.
        /// </summary>
        public static IEntityWrapper<SharePointDocumentLocation> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<SharePointDocumentLocation> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: sharepointsite.
        /// </summary>
        public static IEntityWrapper<SharePointSite> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<SharePointSite> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: socialactivity.
        /// </summary>
        public static IEntityWrapper<SocialActivity> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<SocialActivity> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: socialprofile.
        /// </summary>
        public static IEntityWrapper<SocialProfile> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<SocialProfile> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: task.
        /// </summary>
        public static IEntityWrapper<Task> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Task> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: territory.
        /// </summary>
        public static IEntityWrapper<Territory> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Territory> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: baserecordid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetBaseRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.BaseRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: appointment.
        /// </summary>
        public static IEntityWrapper<Appointment> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Appointment> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: bookableresource.
        /// </summary>
        public static IEntityWrapper<BookableResource> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<BookableResource> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: bookableresourcebooking.
        /// </summary>
        public static IEntityWrapper<BookableResourceBooking> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<BookableResourceBooking> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: bookableresourcebookingheader.
        /// </summary>
        public static IEntityWrapper<BookableResourceBookingHeader> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<BookableResourceBookingHeader> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: bookableresourcecategory.
        /// </summary>
        public static IEntityWrapper<BookableResourceCategory> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<BookableResourceCategory> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: bookableresourcecategoryassn.
        /// </summary>
        public static IEntityWrapper<BookableResourceCategoryAssn> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<BookableResourceCategoryAssn> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: bookableresourcecharacteristic.
        /// </summary>
        public static IEntityWrapper<BookableResourceCharacteristic> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<BookableResourceCharacteristic> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: bookableresourcegroup.
        /// </summary>
        public static IEntityWrapper<BookableResourceGroup> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<BookableResourceGroup> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: bookingstatus.
        /// </summary>
        public static IEntityWrapper<BookingStatus> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<BookingStatus> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: campaignresponse.
        /// </summary>
        public static IEntityWrapper<CampaignResponse> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<CampaignResponse> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: channelaccessprofile.
        /// </summary>
        public static IEntityWrapper<ChannelAccessProfile> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<ChannelAccessProfile> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: characteristic.
        /// </summary>
        public static IEntityWrapper<Characteristic> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Characteristic> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: competitor.
        /// </summary>
        public static IEntityWrapper<Competitor> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Competitor> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: email.
        /// </summary>
        public static IEntityWrapper<Email> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Email> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: emailserverprofile.
        /// </summary>
        public static IEntityWrapper<EmailServerProfile> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<EmailServerProfile> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: entitlement.
        /// </summary>
        public static IEntityWrapper<Entitlement> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Entitlement> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: entitlementchannel.
        /// </summary>
        public static IEntityWrapper<EntitlementChannel> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<EntitlementChannel> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: entitlementtemplate.
        /// </summary>
        public static IEntityWrapper<EntitlementTemplate> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<EntitlementTemplate> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: equipment.
        /// </summary>
        public static IEntityWrapper<Equipment> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Equipment> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: fax.
        /// </summary>
        public static IEntityWrapper<Fax> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Fax> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: goal.
        /// </summary>
        public static IEntityWrapper<Goal> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Goal> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: goalrollupquery.
        /// </summary>
        public static IEntityWrapper<GoalRollupQuery> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<GoalRollupQuery> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: ins_salesorder.
        /// </summary>
        public static IEntityWrapper<ins_salesorder> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<ins_salesorder> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: ins_salesorderline.
        /// </summary>
        public static IEntityWrapper<ins_salesorderline> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<ins_salesorderline> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: kbarticle.
        /// </summary>
        public static IEntityWrapper<KbArticle> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<KbArticle> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: knowledgebaserecord.
        /// </summary>
        public static IEntityWrapper<KnowledgeBaseRecord> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<KnowledgeBaseRecord> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: letter.
        /// </summary>
        public static IEntityWrapper<Letter> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Letter> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: list.
        /// </summary>
        public static IEntityWrapper<List> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<List> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: msdyn_postalbum.
        /// </summary>
        public static IEntityWrapper<msdyn_PostAlbum> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<msdyn_PostAlbum> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: phonecall.
        /// </summary>
        public static IEntityWrapper<PhoneCall> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<PhoneCall> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: publisher.
        /// </summary>
        public static IEntityWrapper<Publisher> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Publisher> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: queue.
        /// </summary>
        public static IEntityWrapper<Queue> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Queue> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: ratingmodel.
        /// </summary>
        public static IEntityWrapper<RatingModel> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<RatingModel> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: ratingvalue.
        /// </summary>
        public static IEntityWrapper<RatingValue> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<RatingValue> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: recurringappointmentmaster.
        /// </summary>
        public static IEntityWrapper<RecurringAppointmentMaster> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<RecurringAppointmentMaster> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: resourcegroup.
        /// </summary>
        public static IEntityWrapper<ResourceGroup> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<ResourceGroup> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: service.
        /// </summary>
        public static IEntityWrapper<Service> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Service> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: sharepointdocumentlocation.
        /// </summary>
        public static IEntityWrapper<SharePointDocumentLocation> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<SharePointDocumentLocation> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: sharepointsite.
        /// </summary>
        public static IEntityWrapper<SharePointSite> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<SharePointSite> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: socialactivity.
        /// </summary>
        public static IEntityWrapper<SocialActivity> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<SocialActivity> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: socialprofile.
        /// </summary>
        public static IEntityWrapper<SocialProfile> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<SocialProfile> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: task.
        /// </summary>
        public static IEntityWrapper<Task> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Task> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: territory.
        /// </summary>
        public static IEntityWrapper<Territory> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Territory> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: duplicaterecordid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetDuplicateRecordID(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRecordId, columnSet);
        /// <summary>
        /// Related attribute: asyncoperationid. Lookup to entity: asyncoperation.
        /// </summary>
        public static IEntityWrapper<AsyncOperation> GetSystemJob(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<AsyncOperation> columnSet)
            => wrapper.GetRelated(e => e.AsyncOperationId, columnSet);
        /// <summary>
        /// Related attribute: duplicateruleid. Lookup to entity: duplicaterule.
        /// </summary>
        public static IEntityWrapper<DuplicateRule> GetDuplicateRuleId(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<DuplicateRule> columnSet)
            => wrapper.GetRelated(e => e.DuplicateRuleId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<DuplicateRecord> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);

    }
    public static class DuplicateRuleConditionExt
    {
        /// <summary>
        /// Related attribute: regardingobjectid. Lookup to entity: duplicaterule.
        /// </summary>
        public static IEntityWrapper<DuplicateRule> GetRegarding(this IEntityWrapperRelation<DuplicateRuleCondition> wrapper, IColumnSet<DuplicateRule> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<DuplicateRuleCondition> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<DuplicateRuleCondition> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<DuplicateRuleCondition> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<DuplicateRuleCondition> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<DuplicateRuleCondition> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<DuplicateRuleCondition> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);

    }
    public static class DynamicPropertyExt
    {
        /// <summary>
        /// Related attribute: basedynamicpropertyid. Lookup to entity: dynamicproperty.
        /// </summary>
        public static IEntityWrapper<DynamicProperty> GetBaseProperty(this IEntityWrapperRelation<DynamicProperty> wrapper, IColumnSet<DynamicProperty> columnSet)
            => wrapper.GetRelated(e => e.BaseDynamicPropertyId, columnSet);
        /// <summary>
        /// Related attribute: defaultvalueoptionset. Lookup to entity: dynamicpropertyoptionsetitem.
        /// </summary>
        public static IEntityWrapper<DynamicPropertyOptionSetItem> GetDefaultOptionSetValue(this IEntityWrapperRelation<DynamicProperty> wrapper, IColumnSet<DynamicPropertyOptionSetItem> columnSet)
            => wrapper.GetRelated(e => e.DefaultValueOptionSet, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<DynamicProperty> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: regardingobjectid. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetRegarding(this IEntityWrapperRelation<DynamicProperty> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);

    }
    public static class DynamicPropertyAssociationExt
    {
        /// <summary>
        /// Related attribute: dynamicpropertyid. Lookup to entity: dynamicproperty.
        /// </summary>
        public static IEntityWrapper<DynamicProperty> GetPropertyID(this IEntityWrapperRelation<DynamicPropertyAssociation> wrapper, IColumnSet<DynamicProperty> columnSet)
            => wrapper.GetRelated(e => e.DynamicPropertyId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<DynamicPropertyAssociation> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetRegarding(this IEntityWrapperRelation<DynamicPropertyAssociation> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectid, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: productassociation.
        /// </summary>
        public static IEntityWrapper<ProductAssociation> GetRegarding(this IEntityWrapperRelation<DynamicPropertyAssociation> wrapper, IColumnSet<ProductAssociation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectid, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<DynamicPropertyAssociation> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class DynamicPropertyInstanceExt
    {
        /// <summary>
        /// Related attribute: dynamicpropertyid. Lookup to entity: dynamicproperty.
        /// </summary>
        public static IEntityWrapper<DynamicProperty> GetPropertyID(this IEntityWrapperRelation<DynamicPropertyInstance> wrapper, IColumnSet<DynamicProperty> columnSet)
            => wrapper.GetRelated(e => e.DynamicPropertyId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: invoicedetail.
        /// </summary>
        public static IEntityWrapper<InvoiceDetail> GetRegarding(this IEntityWrapperRelation<DynamicPropertyInstance> wrapper, IColumnSet<InvoiceDetail> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunityproduct.
        /// </summary>
        public static IEntityWrapper<OpportunityProduct> GetRegarding(this IEntityWrapperRelation<DynamicPropertyInstance> wrapper, IColumnSet<OpportunityProduct> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quotedetail.
        /// </summary>
        public static IEntityWrapper<QuoteDetail> GetRegarding(this IEntityWrapperRelation<DynamicPropertyInstance> wrapper, IColumnSet<QuoteDetail> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesorderdetail.
        /// </summary>
        public static IEntityWrapper<SalesOrderDetail> GetRegarding(this IEntityWrapperRelation<DynamicPropertyInstance> wrapper, IColumnSet<SalesOrderDetail> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<DynamicPropertyInstance> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class DynamicPropertyOptionSetItemExt
    {
        /// <summary>
        /// Related attribute: dynamicpropertyid. Lookup to entity: dynamicproperty.
        /// </summary>
        public static IEntityWrapper<DynamicProperty> GetPropertyID(this IEntityWrapperRelation<DynamicPropertyOptionSetItem> wrapper, IColumnSet<DynamicProperty> columnSet)
            => wrapper.GetRelated(e => e.DynamicPropertyId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<DynamicPropertyOptionSetItem> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<DynamicPropertyOptionSetItem> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class EmailExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: emailsender. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetSender(this IEntityWrapperRelation<Email> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.EmailSender, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: emailsender. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetSender(this IEntityWrapperRelation<Email> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.EmailSender, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: emailsender. Lookup to entity: equipment.
        /// </summary>
        public static IEntityWrapper<Equipment> GetSender(this IEntityWrapperRelation<Email> wrapper, IColumnSet<Equipment> columnSet)
            => wrapper.GetRelated(e => e.EmailSender, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: emailsender. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetSender(this IEntityWrapperRelation<Email> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.EmailSender, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: emailsender. Lookup to entity: queue.
        /// </summary>
        public static IEntityWrapper<Queue> GetSender(this IEntityWrapperRelation<Email> wrapper, IColumnSet<Queue> columnSet)
            => wrapper.GetRelated(e => e.EmailSender, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: emailsender. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetSender(this IEntityWrapperRelation<Email> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.EmailSender, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetRegarding(this IEntityWrapperRelation<Email> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: asyncoperation.
        /// </summary>
        public static IEntityWrapper<AsyncOperation> GetRegarding(this IEntityWrapperRelation<Email> wrapper, IColumnSet<AsyncOperation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebooking.
        /// </summary>
        public static IEntityWrapper<BookableResourceBooking> GetRegarding(this IEntityWrapperRelation<Email> wrapper, IColumnSet<BookableResourceBooking> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebookingheader.
        /// </summary>
        public static IEntityWrapper<BookableResourceBookingHeader> GetRegarding(this IEntityWrapperRelation<Email> wrapper, IColumnSet<BookableResourceBookingHeader> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bulkoperation.
        /// </summary>
        public static IEntityWrapper<BulkOperation> GetRegarding(this IEntityWrapperRelation<Email> wrapper, IColumnSet<BulkOperation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetRegarding(this IEntityWrapperRelation<Email> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaignactivity.
        /// </summary>
        public static IEntityWrapper<CampaignActivity> GetRegarding(this IEntityWrapperRelation<Email> wrapper, IColumnSet<CampaignActivity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetRegarding(this IEntityWrapperRelation<Email> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetRegarding(this IEntityWrapperRelation<Email> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlement.
        /// </summary>
        public static IEntityWrapper<Entitlement> GetRegarding(this IEntityWrapperRelation<Email> wrapper, IColumnSet<Entitlement> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlementtemplate.
        /// </summary>
        public static IEntityWrapper<EntitlementTemplate> GetRegarding(this IEntityWrapperRelation<Email> wrapper, IColumnSet<EntitlementTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetRegarding(this IEntityWrapperRelation<Email> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: invoice.
        /// </summary>
        public static IEntityWrapper<Invoice> GetRegarding(this IEntityWrapperRelation<Email> wrapper, IColumnSet<Invoice> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetRegarding(this IEntityWrapperRelation<Email> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgebaserecord.
        /// </summary>
        public static IEntityWrapper<KnowledgeBaseRecord> GetRegarding(this IEntityWrapperRelation<Email> wrapper, IColumnSet<KnowledgeBaseRecord> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetRegarding(this IEntityWrapperRelation<Email> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_postalbum.
        /// </summary>
        public static IEntityWrapper<msdyn_PostAlbum> GetRegarding(this IEntityWrapperRelation<Email> wrapper, IColumnSet<msdyn_PostAlbum> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetRegarding(this IEntityWrapperRelation<Email> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetRegarding(this IEntityWrapperRelation<Email> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesorder.
        /// </summary>
        public static IEntityWrapper<SalesOrder> GetRegarding(this IEntityWrapperRelation<Email> wrapper, IColumnSet<SalesOrder> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: sendersaccount. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetSendersAccount(this IEntityWrapperRelation<Email> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.SendersAccount, columnSet);
        /// <summary>
        /// Related attribute: parentactivityid. Lookup to entity: email.
        /// </summary>
        public static IEntityWrapper<Email> GetParentActivityId(this IEntityWrapperRelation<Email> wrapper, IColumnSet<Email> columnSet)
            => wrapper.GetRelated(e => e.ParentActivityId, columnSet);
        /// <summary>
        /// Related attribute: sendermailboxid. Lookup to entity: mailbox.
        /// </summary>
        public static IEntityWrapper<Mailbox> GetSenderSMailbox(this IEntityWrapperRelation<Email> wrapper, IColumnSet<Mailbox> columnSet)
            => wrapper.GetRelated(e => e.SenderMailboxId, columnSet);
        /// <summary>
        /// Related attribute: serviceid. Lookup to entity: service.
        /// </summary>
        public static IEntityWrapper<Service> GetService(this IEntityWrapperRelation<Email> wrapper, IColumnSet<Service> columnSet)
            => wrapper.GetRelated(e => e.ServiceId, columnSet);
        /// <summary>
        /// Related attribute: slaid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetSLA(this IEntityWrapperRelation<Email> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAId, columnSet);
        /// <summary>
        /// Related attribute: slainvokedid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetLastSLAApplied(this IEntityWrapperRelation<Email> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAInvokedId, columnSet);
        /// <summary>
        /// Related attribute: templateid. Lookup to entity: template.
        /// </summary>
        public static IEntityWrapper<Template> GetIDForTemplateUsed(this IEntityWrapperRelation<Email> wrapper, IColumnSet<Template> columnSet)
            => wrapper.GetRelated(e => e.TemplateId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Email> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class EmailHashExt
    {
        /// <summary>
        /// Related attribute: activityid. Lookup to entity: activitypointer.
        /// </summary>
        public static IEntityWrapper<ActivityPointer> GetActivityId(this IEntityWrapperRelation<EmailHash> wrapper, IColumnSet<ActivityPointer> columnSet)
            => wrapper.GetRelated(e => e.ActivityId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<EmailHash> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<EmailHash> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);

    }
    public static class EmailSearchExt
    {

    }
    public static class EmailServerProfileExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<EmailServerProfile> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: incomingpartnerapplication. Lookup to entity: partnerapplication.
        /// </summary>
        public static IEntityWrapper<PartnerApplication> GetIncomingPartnerApplication(this IEntityWrapperRelation<EmailServerProfile> wrapper, IColumnSet<PartnerApplication> columnSet)
            => wrapper.GetRelated(e => e.IncomingPartnerApplication, columnSet);
        /// <summary>
        /// Related attribute: outgoingpartnerapplication. Lookup to entity: partnerapplication.
        /// </summary>
        public static IEntityWrapper<PartnerApplication> GetOutgoingPartnerApplication(this IEntityWrapperRelation<EmailServerProfile> wrapper, IColumnSet<PartnerApplication> columnSet)
            => wrapper.GetRelated(e => e.OutgoingPartnerApplication, columnSet);

    }
    public static class EntitlementExt
    {
        /// <summary>
        /// Related attribute: accountid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetAccount(this IEntityWrapperRelation<Entitlement> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.AccountId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: customerid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetCustomer(this IEntityWrapperRelation<Entitlement> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.CustomerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: customerid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetCustomer(this IEntityWrapperRelation<Entitlement> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.CustomerId, columnSet);
        /// <summary>
        /// Related attribute: contactid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetContact(this IEntityWrapperRelation<Entitlement> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.ContactId, columnSet);
        /// <summary>
        /// Related attribute: entitlementtemplateid. Lookup to entity: entitlementtemplate.
        /// </summary>
        public static IEntityWrapper<EntitlementTemplate> GetEntitlementTemplate(this IEntityWrapperRelation<Entitlement> wrapper, IColumnSet<EntitlementTemplate> columnSet)
            => wrapper.GetRelated(e => e.EntitlementTemplateId, columnSet);
        /// <summary>
        /// Related attribute: slaid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetSLA(this IEntityWrapperRelation<Entitlement> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Entitlement> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class EntitlementChannelExt
    {
        /// <summary>
        /// Related attribute: owningbusinessunit. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetOwningBusinessUnit(this IEntityWrapperRelation<EntitlementChannel> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.OwningBusinessUnit, columnSet);
        /// <summary>
        /// Related attribute: entitlementid. Lookup to entity: entitlement.
        /// </summary>
        public static IEntityWrapper<Entitlement> GetEntitlement(this IEntityWrapperRelation<EntitlementChannel> wrapper, IColumnSet<Entitlement> columnSet)
            => wrapper.GetRelated(e => e.EntitlementId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<EntitlementChannel> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<EntitlementChannel> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<EntitlementChannel> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<EntitlementChannel> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<EntitlementChannel> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<EntitlementChannel> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<EntitlementChannel> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Related attribute: owninguser. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwningUser(this IEntityWrapperRelation<EntitlementChannel> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwningUser, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<EntitlementChannel> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class EntitlementTemplateExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<EntitlementTemplate> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: slaid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetSLA(this IEntityWrapperRelation<EntitlementTemplate> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<EntitlementTemplate> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class EntitlementTemplateChannelExt
    {
        /// <summary>
        /// Related attribute: entitlementtemplateid. Lookup to entity: entitlementchannel.
        /// </summary>
        public static IEntityWrapper<EntitlementChannel> GetEntitlementTemplateId(this IEntityWrapperRelation<EntitlementTemplateChannel> wrapper, IColumnSet<EntitlementChannel> columnSet)
            => wrapper.GetRelated(e => e.EntitlementTemplateId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<EntitlementTemplateChannel> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<EntitlementTemplateChannel> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<EntitlementTemplateChannel> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<EntitlementTemplateChannel> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<EntitlementTemplateChannel> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<EntitlementTemplateChannel> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class EntityMapExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<EntityMap> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class EquipmentExt
    {
        /// <summary>
        /// Related attribute: businessunitid. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetBusinessUnit(this IEntityWrapperRelation<Equipment> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.BusinessUnitId, columnSet);
        /// <summary>
        /// Related attribute: calendarid. Lookup to entity: calendar.
        /// </summary>
        public static IEntityWrapper<Calendar> GetCalendar(this IEntityWrapperRelation<Equipment> wrapper, IColumnSet<Calendar> columnSet)
            => wrapper.GetRelated(e => e.CalendarId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<Equipment> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: siteid. Lookup to entity: site.
        /// </summary>
        public static IEntityWrapper<Site> GetSite(this IEntityWrapperRelation<Equipment> wrapper, IColumnSet<Site> columnSet)
            => wrapper.GetRelated(e => e.SiteId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<Equipment> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<Equipment> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<Equipment> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<Equipment> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Equipment> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class ExpiredProcessExt
    {
        /// <summary>
        /// Related attribute: knowledgearticleid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetRelatedKnowledgeArticle(this IEntityWrapperRelation<ExpiredProcess> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.KnowledgeArticleId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<ExpiredProcess> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: activestageid. Lookup to entity: processstage.
        /// </summary>
        public static IEntityWrapper<ProcessStage> GetActiveStage(this IEntityWrapperRelation<ExpiredProcess> wrapper, IColumnSet<ProcessStage> columnSet)
            => wrapper.GetRelated(e => e.ActiveStageId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<ExpiredProcess> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);
        /// <summary>
        /// Related attribute: processid. Lookup to entity: workflow.
        /// </summary>
        public static IEntityWrapper<Workflow> GetProcessId(this IEntityWrapperRelation<ExpiredProcess> wrapper, IColumnSet<Workflow> columnSet)
            => wrapper.GetRelated(e => e.ProcessId, columnSet);

    }
    public static class ExternalPartyExt
    {
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<ExternalParty> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class ExternalPartyItemExt
    {
        /// <summary>
        /// Related attribute: channelaccessprofileid. Lookup to entity: channelaccessprofile.
        /// </summary>
        public static IEntityWrapper<ChannelAccessProfile> GetChannelAccessProfile(this IEntityWrapperRelation<ExternalPartyItem> wrapper, IColumnSet<ChannelAccessProfile> columnSet)
            => wrapper.GetRelated(e => e.ChannelAccessProfileId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetRegarding(this IEntityWrapperRelation<ExternalPartyItem> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetRegarding(this IEntityWrapperRelation<ExternalPartyItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: externalpartyid. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetExternalParty(this IEntityWrapperRelation<ExternalPartyItem> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.ExternalPartyId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<ExternalPartyItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<ExternalPartyItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<ExternalPartyItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<ExternalPartyItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<ExternalPartyItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<ExternalPartyItem> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<ExternalPartyItem> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class FaxExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetRegarding(this IEntityWrapperRelation<Fax> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebooking.
        /// </summary>
        public static IEntityWrapper<BookableResourceBooking> GetRegarding(this IEntityWrapperRelation<Fax> wrapper, IColumnSet<BookableResourceBooking> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebookingheader.
        /// </summary>
        public static IEntityWrapper<BookableResourceBookingHeader> GetRegarding(this IEntityWrapperRelation<Fax> wrapper, IColumnSet<BookableResourceBookingHeader> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bulkoperation.
        /// </summary>
        public static IEntityWrapper<BulkOperation> GetRegarding(this IEntityWrapperRelation<Fax> wrapper, IColumnSet<BulkOperation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetRegarding(this IEntityWrapperRelation<Fax> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaignactivity.
        /// </summary>
        public static IEntityWrapper<CampaignActivity> GetRegarding(this IEntityWrapperRelation<Fax> wrapper, IColumnSet<CampaignActivity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetRegarding(this IEntityWrapperRelation<Fax> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetRegarding(this IEntityWrapperRelation<Fax> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlement.
        /// </summary>
        public static IEntityWrapper<Entitlement> GetRegarding(this IEntityWrapperRelation<Fax> wrapper, IColumnSet<Entitlement> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlementtemplate.
        /// </summary>
        public static IEntityWrapper<EntitlementTemplate> GetRegarding(this IEntityWrapperRelation<Fax> wrapper, IColumnSet<EntitlementTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetRegarding(this IEntityWrapperRelation<Fax> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: invoice.
        /// </summary>
        public static IEntityWrapper<Invoice> GetRegarding(this IEntityWrapperRelation<Fax> wrapper, IColumnSet<Invoice> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetRegarding(this IEntityWrapperRelation<Fax> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgebaserecord.
        /// </summary>
        public static IEntityWrapper<KnowledgeBaseRecord> GetRegarding(this IEntityWrapperRelation<Fax> wrapper, IColumnSet<KnowledgeBaseRecord> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetRegarding(this IEntityWrapperRelation<Fax> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_postalbum.
        /// </summary>
        public static IEntityWrapper<msdyn_PostAlbum> GetRegarding(this IEntityWrapperRelation<Fax> wrapper, IColumnSet<msdyn_PostAlbum> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetRegarding(this IEntityWrapperRelation<Fax> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetRegarding(this IEntityWrapperRelation<Fax> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesorder.
        /// </summary>
        public static IEntityWrapper<SalesOrder> GetRegarding(this IEntityWrapperRelation<Fax> wrapper, IColumnSet<SalesOrder> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: serviceid. Lookup to entity: service.
        /// </summary>
        public static IEntityWrapper<Service> GetService(this IEntityWrapperRelation<Fax> wrapper, IColumnSet<Service> columnSet)
            => wrapper.GetRelated(e => e.ServiceId, columnSet);
        /// <summary>
        /// Related attribute: slaid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetSLA(this IEntityWrapperRelation<Fax> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAId, columnSet);
        /// <summary>
        /// Related attribute: slainvokedid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetLastSLAApplied(this IEntityWrapperRelation<Fax> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAInvokedId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Fax> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class FeedbackExt
    {
        /// <summary>
        /// Related attribute: createdbycontact. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetCreatedByContact(this IEntityWrapperRelation<Feedback> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.CreatedByContact, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfbycontact. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetCreatedOnBelhalfByContact(this IEntityWrapperRelation<Feedback> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfByContact, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetRegarding(this IEntityWrapperRelation<Feedback> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: feedback.
        /// </summary>
        public static IEntityWrapper<Feedback> GetRegarding(this IEntityWrapperRelation<Feedback> wrapper, IColumnSet<Feedback> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetRegarding(this IEntityWrapperRelation<Feedback> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: closedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetClosedBy(this IEntityWrapperRelation<Feedback> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ClosedBy, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Feedback> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class FieldPermissionExt
    {
        /// <summary>
        /// Related attribute: fieldsecurityprofileid. Lookup to entity: fieldsecurityprofile.
        /// </summary>
        public static IEntityWrapper<FieldSecurityProfile> GetProfile(this IEntityWrapperRelation<FieldPermission> wrapper, IColumnSet<FieldSecurityProfile> columnSet)
            => wrapper.GetRelated(e => e.FieldSecurityProfileId, columnSet);

    }
    public static class FieldSecurityProfileExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<FieldSecurityProfile> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class FixedMonthlyFiscalCalendarExt
    {
        /// <summary>
        /// Related attribute: businessunitid. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetBusinessUnit(this IEntityWrapperRelation<FixedMonthlyFiscalCalendar> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.BusinessUnitId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<FixedMonthlyFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedOnBehalfBy(this IEntityWrapperRelation<FixedMonthlyFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<FixedMonthlyFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedOnBehalfBy(this IEntityWrapperRelation<FixedMonthlyFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: salespersonid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetSalesPersonId(this IEntityWrapperRelation<FixedMonthlyFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.SalesPersonId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<FixedMonthlyFiscalCalendar> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class GoalExt
    {
        /// <summary>
        /// Related attribute: goalwitherrorid. Lookup to entity: goal.
        /// </summary>
        public static IEntityWrapper<Goal> GetGoalWithError(this IEntityWrapperRelation<Goal> wrapper, IColumnSet<Goal> columnSet)
            => wrapper.GetRelated(e => e.GoalWithErrorId, columnSet);
        /// <summary>
        /// Related attribute: parentgoalid. Lookup to entity: goal.
        /// </summary>
        public static IEntityWrapper<Goal> GetParentGoal(this IEntityWrapperRelation<Goal> wrapper, IColumnSet<Goal> columnSet)
            => wrapper.GetRelated(e => e.ParentGoalId, columnSet);
        /// <summary>
        /// Related attribute: rollupqueryactualdecimalid. Lookup to entity: goalrollupquery.
        /// </summary>
        public static IEntityWrapper<GoalRollupQuery> GetRollupQueryActualDecimal(this IEntityWrapperRelation<Goal> wrapper, IColumnSet<GoalRollupQuery> columnSet)
            => wrapper.GetRelated(e => e.RollUpQueryActualDecimalId, columnSet);
        /// <summary>
        /// Related attribute: rollupqueryactualintegerid. Lookup to entity: goalrollupquery.
        /// </summary>
        public static IEntityWrapper<GoalRollupQuery> GetRollupQueryActualInteger(this IEntityWrapperRelation<Goal> wrapper, IColumnSet<GoalRollupQuery> columnSet)
            => wrapper.GetRelated(e => e.RollupQueryActualIntegerId, columnSet);
        /// <summary>
        /// Related attribute: rollupqueryactualmoneyid. Lookup to entity: goalrollupquery.
        /// </summary>
        public static IEntityWrapper<GoalRollupQuery> GetRollupQueryActualMoney(this IEntityWrapperRelation<Goal> wrapper, IColumnSet<GoalRollupQuery> columnSet)
            => wrapper.GetRelated(e => e.RollUpQueryActualMoneyId, columnSet);
        /// <summary>
        /// Related attribute: rollupquerycustomdecimalid. Lookup to entity: goalrollupquery.
        /// </summary>
        public static IEntityWrapper<GoalRollupQuery> GetRollupQueryCustomRollupFieldDecimal(this IEntityWrapperRelation<Goal> wrapper, IColumnSet<GoalRollupQuery> columnSet)
            => wrapper.GetRelated(e => e.RollUpQueryCustomDecimalId, columnSet);
        /// <summary>
        /// Related attribute: rollupquerycustomintegerid. Lookup to entity: goalrollupquery.
        /// </summary>
        public static IEntityWrapper<GoalRollupQuery> GetRollupQueryCustomRollupFieldInteger(this IEntityWrapperRelation<Goal> wrapper, IColumnSet<GoalRollupQuery> columnSet)
            => wrapper.GetRelated(e => e.RollUpQueryCustomIntegerId, columnSet);
        /// <summary>
        /// Related attribute: rollupquerycustommoneyid. Lookup to entity: goalrollupquery.
        /// </summary>
        public static IEntityWrapper<GoalRollupQuery> GetRollupQueryCustomRollupFieldMoney(this IEntityWrapperRelation<Goal> wrapper, IColumnSet<GoalRollupQuery> columnSet)
            => wrapper.GetRelated(e => e.RollUpQueryCustomMoneyId, columnSet);
        /// <summary>
        /// Related attribute: rollupqueryinprogressdecimalid. Lookup to entity: goalrollupquery.
        /// </summary>
        public static IEntityWrapper<GoalRollupQuery> GetRollupQueryInProgressdecimal(this IEntityWrapperRelation<Goal> wrapper, IColumnSet<GoalRollupQuery> columnSet)
            => wrapper.GetRelated(e => e.RollUpQueryInprogressDecimalId, columnSet);
        /// <summary>
        /// Related attribute: rollupqueryinprogressintegerid. Lookup to entity: goalrollupquery.
        /// </summary>
        public static IEntityWrapper<GoalRollupQuery> GetRollupQueryInProgressinteger(this IEntityWrapperRelation<Goal> wrapper, IColumnSet<GoalRollupQuery> columnSet)
            => wrapper.GetRelated(e => e.RollUpQueryInprogressIntegerId, columnSet);
        /// <summary>
        /// Related attribute: rollupqueryinprogressmoneyid. Lookup to entity: goalrollupquery.
        /// </summary>
        public static IEntityWrapper<GoalRollupQuery> GetRollupQueryInProgressmoney(this IEntityWrapperRelation<Goal> wrapper, IColumnSet<GoalRollupQuery> columnSet)
            => wrapper.GetRelated(e => e.RollUpQueryInprogressMoneyId, columnSet);
        /// <summary>
        /// Related attribute: metricid. Lookup to entity: metric.
        /// </summary>
        public static IEntityWrapper<Metric> GetGoalMetric(this IEntityWrapperRelation<Goal> wrapper, IColumnSet<Metric> columnSet)
            => wrapper.GetRelated(e => e.MetricId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: goalownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetGoalOwner(this IEntityWrapperRelation<Goal> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.GoalOwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: goalownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetGoalOwner(this IEntityWrapperRelation<Goal> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.GoalOwnerId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Goal> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class HierarchyRuleExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<HierarchyRule> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class ImportDataExt
    {
        /// <summary>
        /// Related attribute: importfileid. Lookup to entity: importfile.
        /// </summary>
        public static IEntityWrapper<ImportFile> GetImportFileId(this IEntityWrapperRelation<ImportData> wrapper, IColumnSet<ImportFile> columnSet)
            => wrapper.GetRelated(e => e.ImportFileId, columnSet);

    }
    public static class ImportEntityMappingExt
    {
        /// <summary>
        /// Related attribute: importmapid. Lookup to entity: importmap.
        /// </summary>
        public static IEntityWrapper<ImportMap> GetDataMapID(this IEntityWrapperRelation<ImportEntityMapping> wrapper, IColumnSet<ImportMap> columnSet)
            => wrapper.GetRelated(e => e.ImportMapId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<ImportEntityMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<ImportEntityMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<ImportEntityMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<ImportEntityMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);

    }
    public static class ImportFileExt
    {
        /// <summary>
        /// Related attribute: importid. Lookup to entity: import.
        /// </summary>
        public static IEntityWrapper<Import> GetImportJobID(this IEntityWrapperRelation<ImportFile> wrapper, IColumnSet<Import> columnSet)
            => wrapper.GetRelated(e => e.ImportId, columnSet);
        /// <summary>
        /// Related attribute: importmapid. Lookup to entity: importmap.
        /// </summary>
        public static IEntityWrapper<ImportMap> GetDataMap(this IEntityWrapperRelation<ImportFile> wrapper, IColumnSet<ImportMap> columnSet)
            => wrapper.GetRelated(e => e.ImportMapId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: recordsownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetRecordsOwner(this IEntityWrapperRelation<ImportFile> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.RecordsOwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: recordsownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetRecordsOwner(this IEntityWrapperRelation<ImportFile> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.RecordsOwnerId, columnSet);

    }
    public static class ImportJobExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<ImportJob> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class ImportLogExt
    {
        /// <summary>
        /// Related attribute: importdataid. Lookup to entity: importdata.
        /// </summary>
        public static IEntityWrapper<ImportData> GetSourceRow(this IEntityWrapperRelation<ImportLog> wrapper, IColumnSet<ImportData> columnSet)
            => wrapper.GetRelated(e => e.ImportDataId, columnSet);
        /// <summary>
        /// Related attribute: importfileid. Lookup to entity: importfile.
        /// </summary>
        public static IEntityWrapper<ImportFile> GetImportFileId(this IEntityWrapperRelation<ImportLog> wrapper, IColumnSet<ImportFile> columnSet)
            => wrapper.GetRelated(e => e.ImportFileId, columnSet);

    }
    public static class IncidentExt
    {
        /// <summary>
        /// Related attribute: accountid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetAccount(this IEntityWrapperRelation<Incident> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.AccountId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: customerid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetCustomer(this IEntityWrapperRelation<Incident> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.CustomerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: customerid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetCustomer(this IEntityWrapperRelation<Incident> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.CustomerId, columnSet);
        /// <summary>
        /// Related attribute: contactid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetContact(this IEntityWrapperRelation<Incident> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.ContactId, columnSet);
        /// <summary>
        /// Related attribute: primarycontactid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetContactContact(this IEntityWrapperRelation<Incident> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.PrimaryContactId, columnSet);
        /// <summary>
        /// Related attribute: responsiblecontactid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetResponsibleContact(this IEntityWrapperRelation<Incident> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.ResponsibleContactId, columnSet);
        /// <summary>
        /// Related attribute: contractid. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetContract(this IEntityWrapperRelation<Incident> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.ContractId, columnSet);
        /// <summary>
        /// Related attribute: contractdetailid. Lookup to entity: contractdetail.
        /// </summary>
        public static IEntityWrapper<ContractDetail> GetContractLine(this IEntityWrapperRelation<Incident> wrapper, IColumnSet<ContractDetail> columnSet)
            => wrapper.GetRelated(e => e.ContractDetailId, columnSet);
        /// <summary>
        /// Related attribute: entitlementid. Lookup to entity: entitlement.
        /// </summary>
        public static IEntityWrapper<Entitlement> GetEntitlement(this IEntityWrapperRelation<Incident> wrapper, IColumnSet<Entitlement> columnSet)
            => wrapper.GetRelated(e => e.EntitlementId, columnSet);
        /// <summary>
        /// Related attribute: createdbyexternalparty. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetCreatedByExternalParty(this IEntityWrapperRelation<Incident> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.CreatedByExternalParty, columnSet);
        /// <summary>
        /// Related attribute: modifiedbyexternalparty. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetModifiedByExternalParty(this IEntityWrapperRelation<Incident> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.ModifiedByExternalParty, columnSet);
        /// <summary>
        /// Related attribute: existingcase. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetExistingCase(this IEntityWrapperRelation<Incident> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.ExistingCase, columnSet);
        /// <summary>
        /// Related attribute: masterid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetMasterCase(this IEntityWrapperRelation<Incident> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.MasterId, columnSet);
        /// <summary>
        /// Related attribute: parentcaseid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetParentCase(this IEntityWrapperRelation<Incident> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.ParentCaseId, columnSet);
        /// <summary>
        /// Related attribute: kbarticleid. Lookup to entity: kbarticle.
        /// </summary>
        public static IEntityWrapper<KbArticle> GetKnowledgeBaseArticle(this IEntityWrapperRelation<Incident> wrapper, IColumnSet<KbArticle> columnSet)
            => wrapper.GetRelated(e => e.KbArticleId, columnSet);
        /// <summary>
        /// Related attribute: productid. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetProduct(this IEntityWrapperRelation<Incident> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.ProductId, columnSet);
        /// <summary>
        /// Related attribute: slaid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetSLA(this IEntityWrapperRelation<Incident> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAId, columnSet);
        /// <summary>
        /// Related attribute: slainvokedid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetLastSLAApplied(this IEntityWrapperRelation<Incident> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAInvokedId, columnSet);
        /// <summary>
        /// Related attribute: firstresponsebykpiid. Lookup to entity: slakpiinstance.
        /// </summary>
        public static IEntityWrapper<SLAKPIInstance> GetFirstResponseByKPI(this IEntityWrapperRelation<Incident> wrapper, IColumnSet<SLAKPIInstance> columnSet)
            => wrapper.GetRelated(e => e.FirstResponseByKPIId, columnSet);
        /// <summary>
        /// Related attribute: resolvebykpiid. Lookup to entity: slakpiinstance.
        /// </summary>
        public static IEntityWrapper<SLAKPIInstance> GetResolveByKPI(this IEntityWrapperRelation<Incident> wrapper, IColumnSet<SLAKPIInstance> columnSet)
            => wrapper.GetRelated(e => e.ResolveByKPIId, columnSet);
        /// <summary>
        /// Related attribute: socialprofileid. Lookup to entity: socialprofile.
        /// </summary>
        public static IEntityWrapper<SocialProfile> GetSocialProfile(this IEntityWrapperRelation<Incident> wrapper, IColumnSet<SocialProfile> columnSet)
            => wrapper.GetRelated(e => e.SocialProfileId, columnSet);
        /// <summary>
        /// Related attribute: subjectid. Lookup to entity: subject.
        /// </summary>
        public static IEntityWrapper<Subject> GetSubject(this IEntityWrapperRelation<Incident> wrapper, IColumnSet<Subject> columnSet)
            => wrapper.GetRelated(e => e.SubjectId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Incident> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class IncidentResolutionExt
    {
        /// <summary>
        /// Related attribute: createdbyexternalparty. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetCreatedByExternalParty(this IEntityWrapperRelation<IncidentResolution> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.CreatedByExternalParty, columnSet);
        /// <summary>
        /// Related attribute: modifiedbyexternalparty. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetModifiedByExternalParty(this IEntityWrapperRelation<IncidentResolution> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.ModifiedByExternalParty, columnSet);
        /// <summary>
        /// Related attribute: incidentid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetCase(this IEntityWrapperRelation<IncidentResolution> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.IncidentId, columnSet);
        /// <summary>
        /// Related attribute: serviceid. Lookup to entity: service.
        /// </summary>
        public static IEntityWrapper<Service> GetService(this IEntityWrapperRelation<IncidentResolution> wrapper, IColumnSet<Service> columnSet)
            => wrapper.GetRelated(e => e.ServiceId, columnSet);

    }
    public static class ins_salesorderExt
    {
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<ins_salesorder> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class ins_salesorderlineExt
    {
        /// <summary>
        /// Related attribute: ins_productid. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetProduct(this IEntityWrapperRelation<ins_salesorderline> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.ins_productid, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<ins_salesorderline> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class InteractionForEmailExt
    {
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<InteractionForEmail> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class InternalAddressExt
    {
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<InternalAddress> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<InternalAddress> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<InternalAddress> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<InternalAddress> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);

    }
    public static class InvoiceExt
    {
        /// <summary>
        /// Related attribute: accountid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetAccount(this IEntityWrapperRelation<Invoice> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.AccountId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: customerid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetCustomer(this IEntityWrapperRelation<Invoice> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.CustomerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: customerid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetCustomer(this IEntityWrapperRelation<Invoice> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.CustomerId, columnSet);
        /// <summary>
        /// Related attribute: contactid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetContact(this IEntityWrapperRelation<Invoice> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.ContactId, columnSet);
        /// <summary>
        /// Related attribute: opportunityid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetOpportunity(this IEntityWrapperRelation<Invoice> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.OpportunityId, columnSet);
        /// <summary>
        /// Related attribute: pricelevelid. Lookup to entity: pricelevel.
        /// </summary>
        public static IEntityWrapper<PriceLevel> GetPriceList(this IEntityWrapperRelation<Invoice> wrapper, IColumnSet<PriceLevel> columnSet)
            => wrapper.GetRelated(e => e.PriceLevelId, columnSet);
        /// <summary>
        /// Related attribute: salesorderid. Lookup to entity: salesorder.
        /// </summary>
        public static IEntityWrapper<SalesOrder> GetOrder(this IEntityWrapperRelation<Invoice> wrapper, IColumnSet<SalesOrder> columnSet)
            => wrapper.GetRelated(e => e.SalesOrderId, columnSet);
        /// <summary>
        /// Related attribute: slaid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetSLA(this IEntityWrapperRelation<Invoice> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAId, columnSet);
        /// <summary>
        /// Related attribute: slainvokedid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetLastSLAApplied(this IEntityWrapperRelation<Invoice> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAInvokedId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Invoice> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class InvoiceDetailExt
    {
        /// <summary>
        /// Related attribute: invoiceid. Lookup to entity: invoice.
        /// </summary>
        public static IEntityWrapper<Invoice> GetInvoiceID(this IEntityWrapperRelation<InvoiceDetail> wrapper, IColumnSet<Invoice> columnSet)
            => wrapper.GetRelated(e => e.InvoiceId, columnSet);
        /// <summary>
        /// Related attribute: productid. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetExistingProduct(this IEntityWrapperRelation<InvoiceDetail> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.ProductId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<InvoiceDetail> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<InvoiceDetail> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<InvoiceDetail> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<InvoiceDetail> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<InvoiceDetail> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<InvoiceDetail> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Related attribute: salesrepid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetSalesperson(this IEntityWrapperRelation<InvoiceDetail> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.SalesRepId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<InvoiceDetail> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);
        /// <summary>
        /// Related attribute: uomid. Lookup to entity: uom.
        /// </summary>
        public static IEntityWrapper<UoM> GetUnit(this IEntityWrapperRelation<InvoiceDetail> wrapper, IColumnSet<UoM> columnSet)
            => wrapper.GetRelated(e => e.UoMId, columnSet);

    }
    public static class KbArticleExt
    {
        /// <summary>
        /// Related attribute: kbarticletemplateid. Lookup to entity: kbarticletemplate.
        /// </summary>
        public static IEntityWrapper<KbArticleTemplate> GetBaseTemplate(this IEntityWrapperRelation<KbArticle> wrapper, IColumnSet<KbArticleTemplate> columnSet)
            => wrapper.GetRelated(e => e.KbArticleTemplateId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<KbArticle> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: subjectid. Lookup to entity: subject.
        /// </summary>
        public static IEntityWrapper<Subject> GetSubject(this IEntityWrapperRelation<KbArticle> wrapper, IColumnSet<Subject> columnSet)
            => wrapper.GetRelated(e => e.SubjectId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<KbArticle> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class KbArticleCommentExt
    {
        /// <summary>
        /// Related attribute: kbarticleid. Lookup to entity: kbarticle.
        /// </summary>
        public static IEntityWrapper<KbArticle> GetKBArticle(this IEntityWrapperRelation<KbArticleComment> wrapper, IColumnSet<KbArticle> columnSet)
            => wrapper.GetRelated(e => e.KbArticleId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<KbArticleComment> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<KbArticleComment> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<KbArticleComment> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<KbArticleComment> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);

    }
    public static class KbArticleTemplateExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<KbArticleTemplate> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class KnowledgeArticleExt
    {
        /// <summary>
        /// Related attribute: parentarticlecontentid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetParentArticleContentId(this IEntityWrapperRelation<KnowledgeArticle> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.ParentArticleContentId, columnSet);
        /// <summary>
        /// Related attribute: previousarticlecontentid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetPreviousArticleContentID(this IEntityWrapperRelation<KnowledgeArticle> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.PreviousArticleContentId, columnSet);
        /// <summary>
        /// Related attribute: rootarticleid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetRootArticleId(this IEntityWrapperRelation<KnowledgeArticle> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.RootArticleId, columnSet);
        /// <summary>
        /// Related attribute: languagelocaleid. Lookup to entity: languagelocale.
        /// </summary>
        public static IEntityWrapper<LanguageLocale> GetLanguage(this IEntityWrapperRelation<KnowledgeArticle> wrapper, IColumnSet<LanguageLocale> columnSet)
            => wrapper.GetRelated(e => e.LanguageLocaleId, columnSet);
        /// <summary>
        /// Related attribute: subjectid. Lookup to entity: subject.
        /// </summary>
        public static IEntityWrapper<Subject> GetSubject(this IEntityWrapperRelation<KnowledgeArticle> wrapper, IColumnSet<Subject> columnSet)
            => wrapper.GetRelated(e => e.SubjectId, columnSet);
        /// <summary>
        /// Related attribute: primaryauthorid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetPrimaryAuthorId(this IEntityWrapperRelation<KnowledgeArticle> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.primaryauthorid, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<KnowledgeArticle> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class KnowledgeArticleIncidentExt
    {
        /// <summary>
        /// Related attribute: incidentid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetIncident(this IEntityWrapperRelation<KnowledgeArticleIncident> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.IncidentId, columnSet);
        /// <summary>
        /// Related attribute: knowledgearticleid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetKnowledgeArticle(this IEntityWrapperRelation<KnowledgeArticleIncident> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.KnowledgeArticleId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<KnowledgeArticleIncident> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<KnowledgeArticleIncident> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<KnowledgeArticleIncident> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<KnowledgeArticleIncident> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<KnowledgeArticleIncident> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<KnowledgeArticleIncident> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<KnowledgeArticleIncident> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class KnowledgeArticleViewsExt
    {
        /// <summary>
        /// Related attribute: knowledgearticleid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetKnowledgeArticle(this IEntityWrapperRelation<KnowledgeArticleViews> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.KnowledgeArticleId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<KnowledgeArticleViews> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<KnowledgeArticleViews> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<KnowledgeArticleViews> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<KnowledgeArticleViews> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<KnowledgeArticleViews> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<KnowledgeArticleViews> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<KnowledgeArticleViews> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class KnowledgeBaseRecordExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<KnowledgeBaseRecord> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<KnowledgeBaseRecord> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class KnowledgeSearchModelExt
    {
        /// <summary>
        /// Related attribute: azureserviceconnectionid. Lookup to entity: azureserviceconnection.
        /// </summary>
        public static IEntityWrapper<AzureServiceConnection> GetConnection(this IEntityWrapperRelation<KnowledgeSearchModel> wrapper, IColumnSet<AzureServiceConnection> columnSet)
            => wrapper.GetRelated(e => e.AzureServiceConnectionId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<KnowledgeSearchModel> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class LanguageLocaleExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<LanguageLocale> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class LeadExt
    {
        /// <summary>
        /// Related attribute: accountid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetAccount(this IEntityWrapperRelation<Lead> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.AccountId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: customerid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetCustomer(this IEntityWrapperRelation<Lead> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.CustomerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: customerid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetCustomer(this IEntityWrapperRelation<Lead> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.CustomerId, columnSet);
        /// <summary>
        /// Related attribute: parentaccountid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetParentAccountForLead(this IEntityWrapperRelation<Lead> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.ParentAccountId, columnSet);
        /// <summary>
        /// Related attribute: campaignid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetSourceCampaign(this IEntityWrapperRelation<Lead> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.CampaignId, columnSet);
        /// <summary>
        /// Related attribute: relatedobjectid. Lookup to entity: campaignresponse.
        /// </summary>
        public static IEntityWrapper<CampaignResponse> GetRelatedCampaignResponse(this IEntityWrapperRelation<Lead> wrapper, IColumnSet<CampaignResponse> columnSet)
            => wrapper.GetRelated(e => e.RelatedObjectId, columnSet);
        /// <summary>
        /// Related attribute: contactid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetContact(this IEntityWrapperRelation<Lead> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.ContactId, columnSet);
        /// <summary>
        /// Related attribute: parentcontactid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetParentContactForLead(this IEntityWrapperRelation<Lead> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.ParentContactId, columnSet);
        /// <summary>
        /// Related attribute: originatingcaseid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetOriginatingCase(this IEntityWrapperRelation<Lead> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.OriginatingCaseId, columnSet);
        /// <summary>
        /// Related attribute: masterid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetMasterID(this IEntityWrapperRelation<Lead> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.MasterId, columnSet);
        /// <summary>
        /// Related attribute: qualifyingopportunityid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetQualifyingOpportunity(this IEntityWrapperRelation<Lead> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.QualifyingOpportunityId, columnSet);
        /// <summary>
        /// Related attribute: slaid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetSLA(this IEntityWrapperRelation<Lead> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAId, columnSet);
        /// <summary>
        /// Related attribute: slainvokedid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetLastSLAApplied(this IEntityWrapperRelation<Lead> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAInvokedId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Lead> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class LeadAddressExt
    {
        /// <summary>
        /// Related attribute: parentid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetParent(this IEntityWrapperRelation<LeadAddress> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.ParentId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<LeadAddress> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<LeadAddress> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<LeadAddress> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<LeadAddress> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<LeadAddress> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class LeadToOpportunitySalesProcessExt
    {
        /// <summary>
        /// Related attribute: leadid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetLeadId(this IEntityWrapperRelation<LeadToOpportunitySalesProcess> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.LeadId, columnSet);
        /// <summary>
        /// Related attribute: opportunityid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetOpportunityId(this IEntityWrapperRelation<LeadToOpportunitySalesProcess> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.OpportunityId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<LeadToOpportunitySalesProcess> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: activestageid. Lookup to entity: processstage.
        /// </summary>
        public static IEntityWrapper<ProcessStage> GetActiveStageId(this IEntityWrapperRelation<LeadToOpportunitySalesProcess> wrapper, IColumnSet<ProcessStage> columnSet)
            => wrapper.GetRelated(e => e.ActiveStageId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<LeadToOpportunitySalesProcess> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);
        /// <summary>
        /// Related attribute: processid. Lookup to entity: workflow.
        /// </summary>
        public static IEntityWrapper<Workflow> GetProcessId(this IEntityWrapperRelation<LeadToOpportunitySalesProcess> wrapper, IColumnSet<Workflow> columnSet)
            => wrapper.GetRelated(e => e.ProcessId, columnSet);

    }
    public static class LetterExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetRegarding(this IEntityWrapperRelation<Letter> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebooking.
        /// </summary>
        public static IEntityWrapper<BookableResourceBooking> GetRegarding(this IEntityWrapperRelation<Letter> wrapper, IColumnSet<BookableResourceBooking> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebookingheader.
        /// </summary>
        public static IEntityWrapper<BookableResourceBookingHeader> GetRegarding(this IEntityWrapperRelation<Letter> wrapper, IColumnSet<BookableResourceBookingHeader> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bulkoperation.
        /// </summary>
        public static IEntityWrapper<BulkOperation> GetRegarding(this IEntityWrapperRelation<Letter> wrapper, IColumnSet<BulkOperation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetRegarding(this IEntityWrapperRelation<Letter> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaignactivity.
        /// </summary>
        public static IEntityWrapper<CampaignActivity> GetRegarding(this IEntityWrapperRelation<Letter> wrapper, IColumnSet<CampaignActivity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetRegarding(this IEntityWrapperRelation<Letter> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetRegarding(this IEntityWrapperRelation<Letter> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlement.
        /// </summary>
        public static IEntityWrapper<Entitlement> GetRegarding(this IEntityWrapperRelation<Letter> wrapper, IColumnSet<Entitlement> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlementtemplate.
        /// </summary>
        public static IEntityWrapper<EntitlementTemplate> GetRegarding(this IEntityWrapperRelation<Letter> wrapper, IColumnSet<EntitlementTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetRegarding(this IEntityWrapperRelation<Letter> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: invoice.
        /// </summary>
        public static IEntityWrapper<Invoice> GetRegarding(this IEntityWrapperRelation<Letter> wrapper, IColumnSet<Invoice> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetRegarding(this IEntityWrapperRelation<Letter> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgebaserecord.
        /// </summary>
        public static IEntityWrapper<KnowledgeBaseRecord> GetRegarding(this IEntityWrapperRelation<Letter> wrapper, IColumnSet<KnowledgeBaseRecord> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetRegarding(this IEntityWrapperRelation<Letter> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_postalbum.
        /// </summary>
        public static IEntityWrapper<msdyn_PostAlbum> GetRegarding(this IEntityWrapperRelation<Letter> wrapper, IColumnSet<msdyn_PostAlbum> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetRegarding(this IEntityWrapperRelation<Letter> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetRegarding(this IEntityWrapperRelation<Letter> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesorder.
        /// </summary>
        public static IEntityWrapper<SalesOrder> GetRegarding(this IEntityWrapperRelation<Letter> wrapper, IColumnSet<SalesOrder> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: serviceid. Lookup to entity: service.
        /// </summary>
        public static IEntityWrapper<Service> GetService(this IEntityWrapperRelation<Letter> wrapper, IColumnSet<Service> columnSet)
            => wrapper.GetRelated(e => e.ServiceId, columnSet);
        /// <summary>
        /// Related attribute: slaid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetSLA(this IEntityWrapperRelation<Letter> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAId, columnSet);
        /// <summary>
        /// Related attribute: slainvokedid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetLastSLAApplied(this IEntityWrapperRelation<Letter> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAInvokedId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Letter> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class LicenseExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<License> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class ListExt
    {
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<List> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class ListMemberExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: entityid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetEntity(this IEntityWrapperRelation<ListMember> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.EntityId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: entityid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetEntity(this IEntityWrapperRelation<ListMember> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.EntityId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: entityid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetEntity(this IEntityWrapperRelation<ListMember> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.EntityId, columnSet);
        /// <summary>
        /// Related attribute: listid. Lookup to entity: list.
        /// </summary>
        public static IEntityWrapper<List> GetMarketingList(this IEntityWrapperRelation<ListMember> wrapper, IColumnSet<List> columnSet)
            => wrapper.GetRelated(e => e.ListId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<ListMember> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedOnBehalfBy(this IEntityWrapperRelation<ListMember> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<ListMember> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedOnBehalfBy(this IEntityWrapperRelation<ListMember> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<ListMember> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<ListMember> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);

    }
    public static class LookUpMappingExt
    {
        /// <summary>
        /// Related attribute: columnmappingid. Lookup to entity: columnmapping.
        /// </summary>
        public static IEntityWrapper<ColumnMapping> GetColumnMappingId(this IEntityWrapperRelation<LookUpMapping> wrapper, IColumnSet<ColumnMapping> columnSet)
            => wrapper.GetRelated(e => e.ColumnMappingId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<LookUpMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<LookUpMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<LookUpMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<LookUpMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: transformationparametermappingid. Lookup to entity: transformationparametermapping.
        /// </summary>
        public static IEntityWrapper<TransformationParameterMapping> GetTransformationParameterMappingId(this IEntityWrapperRelation<LookUpMapping> wrapper, IColumnSet<TransformationParameterMapping> columnSet)
            => wrapper.GetRelated(e => e.TransformationParameterMappingId, columnSet);

    }
    public static class MailboxExt
    {
        /// <summary>
        /// Related attribute: emailserverprofile. Lookup to entity: emailserverprofile.
        /// </summary>
        public static IEntityWrapper<EmailServerProfile> GetServerProfile(this IEntityWrapperRelation<Mailbox> wrapper, IColumnSet<EmailServerProfile> columnSet)
            => wrapper.GetRelated(e => e.EmailServerProfile, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<Mailbox> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: queue.
        /// </summary>
        public static IEntityWrapper<Queue> GetRegarding(this IEntityWrapperRelation<Mailbox> wrapper, IColumnSet<Queue> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetRegarding(this IEntityWrapperRelation<Mailbox> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);

    }
    public static class MailboxStatisticsExt
    {
        /// <summary>
        /// Related attribute: mailboxid. Lookup to entity: mailbox.
        /// </summary>
        public static IEntityWrapper<Mailbox> GetRegardingMailbox(this IEntityWrapperRelation<MailboxStatistics> wrapper, IColumnSet<Mailbox> columnSet)
            => wrapper.GetRelated(e => e.MailboxId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<MailboxStatistics> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class MailboxTrackingFolderExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetRegardingObjectId(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: asyncoperation.
        /// </summary>
        public static IEntityWrapper<AsyncOperation> GetRegardingObjectId(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<AsyncOperation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebooking.
        /// </summary>
        public static IEntityWrapper<BookableResourceBooking> GetRegardingObjectId(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<BookableResourceBooking> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebookingheader.
        /// </summary>
        public static IEntityWrapper<BookableResourceBookingHeader> GetRegardingObjectId(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<BookableResourceBookingHeader> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bulkoperation.
        /// </summary>
        public static IEntityWrapper<BulkOperation> GetRegardingObjectId(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<BulkOperation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetRegardingObjectId(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaignactivity.
        /// </summary>
        public static IEntityWrapper<CampaignActivity> GetRegardingObjectId(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<CampaignActivity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetRegardingObjectId(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetRegardingObjectId(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlement.
        /// </summary>
        public static IEntityWrapper<Entitlement> GetRegardingObjectId(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<Entitlement> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlementtemplate.
        /// </summary>
        public static IEntityWrapper<EntitlementTemplate> GetRegardingObjectId(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<EntitlementTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetRegardingObjectId(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: ins_salesorder.
        /// </summary>
        public static IEntityWrapper<ins_salesorder> GetRegardingObjectId(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<ins_salesorder> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: ins_salesorderline.
        /// </summary>
        public static IEntityWrapper<ins_salesorderline> GetRegardingObjectId(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<ins_salesorderline> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: invoice.
        /// </summary>
        public static IEntityWrapper<Invoice> GetRegardingObjectId(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<Invoice> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetRegardingObjectId(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_postalbum.
        /// </summary>
        public static IEntityWrapper<msdyn_PostAlbum> GetRegardingObjectId(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<msdyn_PostAlbum> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_postconfig.
        /// </summary>
        public static IEntityWrapper<msdyn_PostConfig> GetRegardingObjectId(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<msdyn_PostConfig> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_postruleconfig.
        /// </summary>
        public static IEntityWrapper<msdyn_PostRuleConfig> GetRegardingObjectId(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<msdyn_PostRuleConfig> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_wallsavedquery.
        /// </summary>
        public static IEntityWrapper<msdyn_wallsavedquery> GetRegardingObjectId(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<msdyn_wallsavedquery> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_wallsavedqueryusersettings.
        /// </summary>
        public static IEntityWrapper<msdyn_wallsavedqueryusersettings> GetRegardingObjectId(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<msdyn_wallsavedqueryusersettings> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetRegardingObjectId(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetRegardingObjectId(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesorder.
        /// </summary>
        public static IEntityWrapper<SalesOrder> GetRegardingObjectId(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<SalesOrder> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: mailboxid. Lookup to entity: mailbox.
        /// </summary>
        public static IEntityWrapper<Mailbox> GetMailboxId(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<Mailbox> columnSet)
            => wrapper.GetRelated(e => e.MailboxId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<MailboxTrackingFolder> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class MailMergeTemplateExt
    {
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<MailMergeTemplate> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class MetricExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<Metric> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class MobileOfflineProfileExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<MobileOfflineProfile> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class MobileOfflineProfileItemExt
    {
        /// <summary>
        /// Related attribute: regardingobjectid. Lookup to entity: mobileofflineprofile.
        /// </summary>
        public static IEntityWrapper<MobileOfflineProfile> GetRegarding(this IEntityWrapperRelation<MobileOfflineProfileItem> wrapper, IColumnSet<MobileOfflineProfile> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<MobileOfflineProfileItem> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: profileitemrule. Lookup to entity: savedquery.
        /// </summary>
        public static IEntityWrapper<SavedQuery> GetViewToSyncDataToDevice(this IEntityWrapperRelation<MobileOfflineProfileItem> wrapper, IColumnSet<SavedQuery> columnSet)
            => wrapper.GetRelated(e => e.ProfileItemRule, columnSet);

    }
    public static class MobileOfflineProfileItemAssociationExt
    {
        /// <summary>
        /// Related attribute: mobileofflineprofileitemid. Lookup to entity: mobileofflineprofileitem.
        /// </summary>
        public static IEntityWrapper<MobileOfflineProfileItem> GetRegarding(this IEntityWrapperRelation<MobileOfflineProfileItemAssociation> wrapper, IColumnSet<MobileOfflineProfileItem> columnSet)
            => wrapper.GetRelated(e => e.MobileOfflineProfileItemId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<MobileOfflineProfileItemAssociation> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class MonthlyFiscalCalendarExt
    {
        /// <summary>
        /// Related attribute: businessunitid. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetBusinessUnitId(this IEntityWrapperRelation<MonthlyFiscalCalendar> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.BusinessUnitId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<MonthlyFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<MonthlyFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<MonthlyFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<MonthlyFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: salespersonid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetSalesPersonId(this IEntityWrapperRelation<MonthlyFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.SalesPersonId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<MonthlyFiscalCalendar> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class msdyn_PostConfigExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<msdyn_PostConfig> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class msdyn_PostRuleConfigExt
    {
        /// <summary>
        /// Related attribute: msdyn_postconfigid. Lookup to entity: msdyn_postconfig.
        /// </summary>
        public static IEntityWrapper<msdyn_PostConfig> GetPostEntityId(this IEntityWrapperRelation<msdyn_PostRuleConfig> wrapper, IColumnSet<msdyn_PostConfig> columnSet)
            => wrapper.GetRelated(e => e.msdyn_PostConfigId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<msdyn_PostRuleConfig> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class msdyn_wallsavedqueryExt
    {
        /// <summary>
        /// Related attribute: msdyn_postconfigurationid. Lookup to entity: msdyn_postconfig.
        /// </summary>
        public static IEntityWrapper<msdyn_PostConfig> GetPostEntityId(this IEntityWrapperRelation<msdyn_wallsavedquery> wrapper, IColumnSet<msdyn_PostConfig> columnSet)
            => wrapper.GetRelated(e => e.msdyn_postconfigurationid, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<msdyn_wallsavedquery> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class msdyn_wallsavedqueryusersettingsExt
    {
        /// <summary>
        /// Related attribute: msdyn_wallsavedqueryid. Lookup to entity: msdyn_wallsavedquery.
        /// </summary>
        public static IEntityWrapper<msdyn_wallsavedquery> GetWallViewId(this IEntityWrapperRelation<msdyn_wallsavedqueryusersettings> wrapper, IColumnSet<msdyn_wallsavedquery> columnSet)
            => wrapper.GetRelated(e => e.msdyn_wallsavedqueryid, columnSet);
        /// <summary>
        /// Related attribute: msdyn_userid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetUserId(this IEntityWrapperRelation<msdyn_wallsavedqueryusersettings> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.msdyn_userid, columnSet);

    }
    public static class MultiEntitySearchExt
    {
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<MultiEntitySearch> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<MultiEntitySearch> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<MultiEntitySearch> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<MultiEntitySearch> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);

    }
    public static class MultiEntitySearchEntitiesExt
    {
        /// <summary>
        /// Related attribute: multientitysearchid. Lookup to entity: multientitysearch.
        /// </summary>
        public static IEntityWrapper<MultiEntitySearch> GetMultiEntitySearchId(this IEntityWrapperRelation<MultiEntitySearchEntities> wrapper, IColumnSet<MultiEntitySearch> columnSet)
            => wrapper.GetRelated(e => e.MultiEntitySearchId, columnSet);

    }
    public static class NewProcessExt
    {
        /// <summary>
        /// Related attribute: knowledgearticleid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetKnowledgeArticleId(this IEntityWrapperRelation<NewProcess> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.KnowledgeArticleId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<NewProcess> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: activestageid. Lookup to entity: processstage.
        /// </summary>
        public static IEntityWrapper<ProcessStage> GetActiveStageId(this IEntityWrapperRelation<NewProcess> wrapper, IColumnSet<ProcessStage> columnSet)
            => wrapper.GetRelated(e => e.ActiveStageId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<NewProcess> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);
        /// <summary>
        /// Related attribute: processid. Lookup to entity: workflow.
        /// </summary>
        public static IEntityWrapper<Workflow> GetProcessId(this IEntityWrapperRelation<NewProcess> wrapper, IColumnSet<Workflow> columnSet)
            => wrapper.GetRelated(e => e.ProcessId, columnSet);

    }
    public static class OfficeDocumentExt
    {
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<OfficeDocument> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<OfficeDocument> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<OfficeDocument> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegateUser(this IEntityWrapperRelation<OfficeDocument> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<OfficeDocument> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<OfficeDocument> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);

    }
    public static class OfficeGraphDocumentExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<OfficeGraphDocument> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<OfficeGraphDocument> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class OpportunityExt
    {
        /// <summary>
        /// Related attribute: accountid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> Get(this IEntityWrapperRelation<Opportunity> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.AccountId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: customerid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetPotentialCustomer(this IEntityWrapperRelation<Opportunity> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.CustomerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: customerid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetPotentialCustomer(this IEntityWrapperRelation<Opportunity> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.CustomerId, columnSet);
        /// <summary>
        /// Related attribute: parentaccountid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetAccount(this IEntityWrapperRelation<Opportunity> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.ParentAccountId, columnSet);
        /// <summary>
        /// Related attribute: campaignid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetSourceCampaign(this IEntityWrapperRelation<Opportunity> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.CampaignId, columnSet);
        /// <summary>
        /// Related attribute: contactid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetContact(this IEntityWrapperRelation<Opportunity> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.ContactId, columnSet);
        /// <summary>
        /// Related attribute: parentcontactid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetContactContact(this IEntityWrapperRelation<Opportunity> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.ParentContactId, columnSet);
        /// <summary>
        /// Related attribute: originatingleadid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetOriginatingLead(this IEntityWrapperRelation<Opportunity> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.OriginatingLeadId, columnSet);
        /// <summary>
        /// Related attribute: pricelevelid. Lookup to entity: pricelevel.
        /// </summary>
        public static IEntityWrapper<PriceLevel> GetPriceList(this IEntityWrapperRelation<Opportunity> wrapper, IColumnSet<PriceLevel> columnSet)
            => wrapper.GetRelated(e => e.PriceLevelId, columnSet);
        /// <summary>
        /// Related attribute: slaid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetSLA(this IEntityWrapperRelation<Opportunity> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAId, columnSet);
        /// <summary>
        /// Related attribute: slainvokedid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetLastSLAApplied(this IEntityWrapperRelation<Opportunity> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAInvokedId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Opportunity> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class OpportunityCloseExt
    {
        /// <summary>
        /// Related attribute: competitorid. Lookup to entity: competitor.
        /// </summary>
        public static IEntityWrapper<Competitor> GetCompetitor(this IEntityWrapperRelation<OpportunityClose> wrapper, IColumnSet<Competitor> columnSet)
            => wrapper.GetRelated(e => e.CompetitorId, columnSet);
        /// <summary>
        /// Related attribute: createdbyexternalparty. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetCreatedByExternalParty(this IEntityWrapperRelation<OpportunityClose> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.CreatedByExternalParty, columnSet);
        /// <summary>
        /// Related attribute: modifiedbyexternalparty. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetModifiedByExternalParty(this IEntityWrapperRelation<OpportunityClose> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.ModifiedByExternalParty, columnSet);
        /// <summary>
        /// Related attribute: opportunityid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetOpportunity(this IEntityWrapperRelation<OpportunityClose> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.OpportunityId, columnSet);
        /// <summary>
        /// Related attribute: serviceid. Lookup to entity: service.
        /// </summary>
        public static IEntityWrapper<Service> GetService(this IEntityWrapperRelation<OpportunityClose> wrapper, IColumnSet<Service> columnSet)
            => wrapper.GetRelated(e => e.ServiceId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<OpportunityClose> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class OpportunityProductExt
    {
        /// <summary>
        /// Related attribute: opportunityid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetOpportunity(this IEntityWrapperRelation<OpportunityProduct> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.OpportunityId, columnSet);
        /// <summary>
        /// Related attribute: productid. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetExistingProduct(this IEntityWrapperRelation<OpportunityProduct> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.ProductId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<OpportunityProduct> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<OpportunityProduct> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<OpportunityProduct> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<OpportunityProduct> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<OpportunityProduct> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<OpportunityProduct> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<OpportunityProduct> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);
        /// <summary>
        /// Related attribute: uomid. Lookup to entity: uom.
        /// </summary>
        public static IEntityWrapper<UoM> GetUnit(this IEntityWrapperRelation<OpportunityProduct> wrapper, IColumnSet<UoM> columnSet)
            => wrapper.GetRelated(e => e.UoMId, columnSet);

    }
    public static class OpportunitySalesProcessExt
    {
        /// <summary>
        /// Related attribute: opportunityid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetRelatedOpportunity(this IEntityWrapperRelation<OpportunitySalesProcess> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.OpportunityId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<OpportunitySalesProcess> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: activestageid. Lookup to entity: processstage.
        /// </summary>
        public static IEntityWrapper<ProcessStage> GetActiveStage(this IEntityWrapperRelation<OpportunitySalesProcess> wrapper, IColumnSet<ProcessStage> columnSet)
            => wrapper.GetRelated(e => e.ActiveStageId, columnSet);
        /// <summary>
        /// Related attribute: quoteid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetRelatedQuote(this IEntityWrapperRelation<OpportunitySalesProcess> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.QuoteId, columnSet);
        /// <summary>
        /// Related attribute: salesorderid. Lookup to entity: salesorder.
        /// </summary>
        public static IEntityWrapper<SalesOrder> GetRelatedSalesOrder(this IEntityWrapperRelation<OpportunitySalesProcess> wrapper, IColumnSet<SalesOrder> columnSet)
            => wrapper.GetRelated(e => e.SalesOrderId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<OpportunitySalesProcess> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);
        /// <summary>
        /// Related attribute: processid. Lookup to entity: workflow.
        /// </summary>
        public static IEntityWrapper<Workflow> GetProcessId(this IEntityWrapperRelation<OpportunitySalesProcess> wrapper, IColumnSet<Workflow> columnSet)
            => wrapper.GetRelated(e => e.ProcessId, columnSet);

    }
    public static class OrderCloseExt
    {
        /// <summary>
        /// Related attribute: createdbyexternalparty. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetCreatedByExternalParty(this IEntityWrapperRelation<OrderClose> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.CreatedByExternalParty, columnSet);
        /// <summary>
        /// Related attribute: modifiedbyexternalparty. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetModifiedByExternalParty(this IEntityWrapperRelation<OrderClose> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.ModifiedByExternalParty, columnSet);
        /// <summary>
        /// Related attribute: salesorderid. Lookup to entity: salesorder.
        /// </summary>
        public static IEntityWrapper<SalesOrder> GetOrder(this IEntityWrapperRelation<OrderClose> wrapper, IColumnSet<SalesOrder> columnSet)
            => wrapper.GetRelated(e => e.SalesOrderId, columnSet);
        /// <summary>
        /// Related attribute: serviceid. Lookup to entity: service.
        /// </summary>
        public static IEntityWrapper<Service> GetService(this IEntityWrapperRelation<OrderClose> wrapper, IColumnSet<Service> columnSet)
            => wrapper.GetRelated(e => e.ServiceId, columnSet);

    }
    public static class OrganizationExt
    {
        /// <summary>
        /// Related attribute: defaultemailserverprofileid. Lookup to entity: emailserverprofile.
        /// </summary>
        public static IEntityWrapper<EmailServerProfile> GetEmailServerProfile(this IEntityWrapperRelation<Organization> wrapper, IColumnSet<EmailServerProfile> columnSet)
            => wrapper.GetRelated(e => e.DefaultEmailServerProfileId, columnSet);
        /// <summary>
        /// Related attribute: defaultmobileofflineprofileid. Lookup to entity: mobileofflineprofile.
        /// </summary>
        public static IEntityWrapper<MobileOfflineProfile> GetDefaultMobileOfflineProfile(this IEntityWrapperRelation<Organization> wrapper, IColumnSet<MobileOfflineProfile> columnSet)
            => wrapper.GetRelated(e => e.DefaultMobileOfflineProfileId, columnSet);
        /// <summary>
        /// Related attribute: acknowledgementtemplateid. Lookup to entity: template.
        /// </summary>
        public static IEntityWrapper<Template> GetAcknowledgementTemplate(this IEntityWrapperRelation<Organization> wrapper, IColumnSet<Template> columnSet)
            => wrapper.GetRelated(e => e.AcknowledgementTemplateId, columnSet);
        /// <summary>
        /// Related attribute: basecurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Organization> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.BaseCurrencyId, columnSet);

    }
    public static class OrganizationUIExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<OrganizationUI> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class OrgInsightsMetricExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<OrgInsightsMetric> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class OwnerMappingExt
    {
        /// <summary>
        /// Related attribute: targetsystemuserid. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetTargetSystemUser(this IEntityWrapperRelation<OwnerMapping> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.TargetSystemUserId, columnSet);
        /// <summary>
        /// Related attribute: importmapid. Lookup to entity: importmap.
        /// </summary>
        public static IEntityWrapper<ImportMap> GetDataMap(this IEntityWrapperRelation<OwnerMapping> wrapper, IColumnSet<ImportMap> columnSet)
            => wrapper.GetRelated(e => e.ImportMapId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<OwnerMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<OwnerMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<OwnerMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<OwnerMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);

    }
    public static class PartnerApplicationExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<PartnerApplication> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class PhoneCallExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetRegarding(this IEntityWrapperRelation<PhoneCall> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebooking.
        /// </summary>
        public static IEntityWrapper<BookableResourceBooking> GetRegarding(this IEntityWrapperRelation<PhoneCall> wrapper, IColumnSet<BookableResourceBooking> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebookingheader.
        /// </summary>
        public static IEntityWrapper<BookableResourceBookingHeader> GetRegarding(this IEntityWrapperRelation<PhoneCall> wrapper, IColumnSet<BookableResourceBookingHeader> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bulkoperation.
        /// </summary>
        public static IEntityWrapper<BulkOperation> GetRegarding(this IEntityWrapperRelation<PhoneCall> wrapper, IColumnSet<BulkOperation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetRegarding(this IEntityWrapperRelation<PhoneCall> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaignactivity.
        /// </summary>
        public static IEntityWrapper<CampaignActivity> GetRegarding(this IEntityWrapperRelation<PhoneCall> wrapper, IColumnSet<CampaignActivity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetRegarding(this IEntityWrapperRelation<PhoneCall> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetRegarding(this IEntityWrapperRelation<PhoneCall> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlement.
        /// </summary>
        public static IEntityWrapper<Entitlement> GetRegarding(this IEntityWrapperRelation<PhoneCall> wrapper, IColumnSet<Entitlement> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlementtemplate.
        /// </summary>
        public static IEntityWrapper<EntitlementTemplate> GetRegarding(this IEntityWrapperRelation<PhoneCall> wrapper, IColumnSet<EntitlementTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetRegarding(this IEntityWrapperRelation<PhoneCall> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: invoice.
        /// </summary>
        public static IEntityWrapper<Invoice> GetRegarding(this IEntityWrapperRelation<PhoneCall> wrapper, IColumnSet<Invoice> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetRegarding(this IEntityWrapperRelation<PhoneCall> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgebaserecord.
        /// </summary>
        public static IEntityWrapper<KnowledgeBaseRecord> GetRegarding(this IEntityWrapperRelation<PhoneCall> wrapper, IColumnSet<KnowledgeBaseRecord> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetRegarding(this IEntityWrapperRelation<PhoneCall> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_postalbum.
        /// </summary>
        public static IEntityWrapper<msdyn_PostAlbum> GetRegarding(this IEntityWrapperRelation<PhoneCall> wrapper, IColumnSet<msdyn_PostAlbum> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetRegarding(this IEntityWrapperRelation<PhoneCall> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetRegarding(this IEntityWrapperRelation<PhoneCall> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesorder.
        /// </summary>
        public static IEntityWrapper<SalesOrder> GetRegarding(this IEntityWrapperRelation<PhoneCall> wrapper, IColumnSet<SalesOrder> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: serviceid. Lookup to entity: service.
        /// </summary>
        public static IEntityWrapper<Service> GetService(this IEntityWrapperRelation<PhoneCall> wrapper, IColumnSet<Service> columnSet)
            => wrapper.GetRelated(e => e.ServiceId, columnSet);
        /// <summary>
        /// Related attribute: slaid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetSLA(this IEntityWrapperRelation<PhoneCall> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAId, columnSet);
        /// <summary>
        /// Related attribute: slainvokedid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetLastSLAApplied(this IEntityWrapperRelation<PhoneCall> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAInvokedId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<PhoneCall> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class PhoneToCaseProcessExt
    {
        /// <summary>
        /// Related attribute: incidentid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetIncidentId(this IEntityWrapperRelation<PhoneToCaseProcess> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.IncidentId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<PhoneToCaseProcess> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: activestageid. Lookup to entity: processstage.
        /// </summary>
        public static IEntityWrapper<ProcessStage> GetActiveStageId(this IEntityWrapperRelation<PhoneToCaseProcess> wrapper, IColumnSet<ProcessStage> columnSet)
            => wrapper.GetRelated(e => e.ActiveStageId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<PhoneToCaseProcess> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);
        /// <summary>
        /// Related attribute: processid. Lookup to entity: workflow.
        /// </summary>
        public static IEntityWrapper<Workflow> GetProcessId(this IEntityWrapperRelation<PhoneToCaseProcess> wrapper, IColumnSet<Workflow> columnSet)
            => wrapper.GetRelated(e => e.ProcessId, columnSet);

    }
    public static class PickListMappingExt
    {
        /// <summary>
        /// Related attribute: columnmappingid. Lookup to entity: columnmapping.
        /// </summary>
        public static IEntityWrapper<ColumnMapping> GetColumnMappingId(this IEntityWrapperRelation<PickListMapping> wrapper, IColumnSet<ColumnMapping> columnSet)
            => wrapper.GetRelated(e => e.ColumnMappingId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<PickListMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<PickListMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<PickListMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<PickListMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);

    }
    public static class PluginAssemblyExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<PluginAssembly> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class PluginTypeExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<PluginType> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: pluginassemblyid. Lookup to entity: pluginassembly.
        /// </summary>
        public static IEntityWrapper<PluginAssembly> GetPluginAssembly(this IEntityWrapperRelation<PluginType> wrapper, IColumnSet<PluginAssembly> columnSet)
            => wrapper.GetRelated(e => e.PluginAssemblyId, columnSet);

    }
    public static class PluginTypeStatisticExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<PluginTypeStatistic> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: plugintypeid. Lookup to entity: plugintype.
        /// </summary>
        public static IEntityWrapper<PluginType> GetPluginType(this IEntityWrapperRelation<PluginTypeStatistic> wrapper, IColumnSet<PluginType> columnSet)
            => wrapper.GetRelated(e => e.PluginTypeId, columnSet);

    }
    public static class PositionExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<Position> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: parentpositionid. Lookup to entity: position.
        /// </summary>
        public static IEntityWrapper<Position> GetParentPosition(this IEntityWrapperRelation<Position> wrapper, IColumnSet<Position> columnSet)
            => wrapper.GetRelated(e => e.ParentPositionId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Position> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class PostExt
    {
        /// <summary>
        /// Related attribute: regardingobjectowningbusinessunit. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetRegardingObjectOwningBusinessUnit(this IEntityWrapperRelation<Post> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectOwningBusinessUnit, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<Post> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: postregardingid. Lookup to entity: postregarding.
        /// </summary>
        public static IEntityWrapper<PostRegarding> GetPostRegarding(this IEntityWrapperRelation<Post> wrapper, IColumnSet<PostRegarding> columnSet)
            => wrapper.GetRelated(e => e.PostRegardingId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<Post> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectOwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<Post> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectOwnerId, columnSet);

    }
    public static class PostCommentExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<PostComment> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: postid. Lookup to entity: post.
        /// </summary>
        public static IEntityWrapper<Post> GetPost(this IEntityWrapperRelation<PostComment> wrapper, IColumnSet<Post> columnSet)
            => wrapper.GetRelated(e => e.PostId, columnSet);

    }
    public static class PostFollowExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetRegarding(this IEntityWrapperRelation<PostFollow> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: appointment.
        /// </summary>
        public static IEntityWrapper<Appointment> GetRegarding(this IEntityWrapperRelation<PostFollow> wrapper, IColumnSet<Appointment> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: competitor.
        /// </summary>
        public static IEntityWrapper<Competitor> GetRegarding(this IEntityWrapperRelation<PostFollow> wrapper, IColumnSet<Competitor> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetRegarding(this IEntityWrapperRelation<PostFollow> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetRegarding(this IEntityWrapperRelation<PostFollow> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetRegarding(this IEntityWrapperRelation<PostFollow> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetRegarding(this IEntityWrapperRelation<PostFollow> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetRegarding(this IEntityWrapperRelation<PostFollow> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: phonecall.
        /// </summary>
        public static IEntityWrapper<PhoneCall> GetRegarding(this IEntityWrapperRelation<PostFollow> wrapper, IColumnSet<PhoneCall> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: processsession.
        /// </summary>
        public static IEntityWrapper<ProcessSession> GetRegarding(this IEntityWrapperRelation<PostFollow> wrapper, IColumnSet<ProcessSession> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: queue.
        /// </summary>
        public static IEntityWrapper<Queue> GetRegarding(this IEntityWrapperRelation<PostFollow> wrapper, IColumnSet<Queue> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: recurringappointmentmaster.
        /// </summary>
        public static IEntityWrapper<RecurringAppointmentMaster> GetRegarding(this IEntityWrapperRelation<PostFollow> wrapper, IColumnSet<RecurringAppointmentMaster> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetRegarding(this IEntityWrapperRelation<PostFollow> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: task.
        /// </summary>
        public static IEntityWrapper<Task> GetRegarding(this IEntityWrapperRelation<PostFollow> wrapper, IColumnSet<Task> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);

    }
    public static class PostLikeExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<PostLike> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: postid. Lookup to entity: post.
        /// </summary>
        public static IEntityWrapper<Post> GetPost(this IEntityWrapperRelation<PostLike> wrapper, IColumnSet<Post> columnSet)
            => wrapper.GetRelated(e => e.PostId, columnSet);

    }
    public static class PostRegardingExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetRegardingObjectId(this IEntityWrapperRelation<PostRegarding> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: appointment.
        /// </summary>
        public static IEntityWrapper<Appointment> GetRegardingObjectId(this IEntityWrapperRelation<PostRegarding> wrapper, IColumnSet<Appointment> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: competitor.
        /// </summary>
        public static IEntityWrapper<Competitor> GetRegardingObjectId(this IEntityWrapperRelation<PostRegarding> wrapper, IColumnSet<Competitor> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetRegardingObjectId(this IEntityWrapperRelation<PostRegarding> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetRegardingObjectId(this IEntityWrapperRelation<PostRegarding> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetRegardingObjectId(this IEntityWrapperRelation<PostRegarding> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetRegardingObjectId(this IEntityWrapperRelation<PostRegarding> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetRegardingObjectId(this IEntityWrapperRelation<PostRegarding> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetRegardingObjectId(this IEntityWrapperRelation<PostRegarding> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: phonecall.
        /// </summary>
        public static IEntityWrapper<PhoneCall> GetRegardingObjectId(this IEntityWrapperRelation<PostRegarding> wrapper, IColumnSet<PhoneCall> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: processsession.
        /// </summary>
        public static IEntityWrapper<ProcessSession> GetRegardingObjectId(this IEntityWrapperRelation<PostRegarding> wrapper, IColumnSet<ProcessSession> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: queue.
        /// </summary>
        public static IEntityWrapper<Queue> GetRegardingObjectId(this IEntityWrapperRelation<PostRegarding> wrapper, IColumnSet<Queue> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: recurringappointmentmaster.
        /// </summary>
        public static IEntityWrapper<RecurringAppointmentMaster> GetRegardingObjectId(this IEntityWrapperRelation<PostRegarding> wrapper, IColumnSet<RecurringAppointmentMaster> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetRegardingObjectId(this IEntityWrapperRelation<PostRegarding> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: task.
        /// </summary>
        public static IEntityWrapper<Task> GetRegardingObjectId(this IEntityWrapperRelation<PostRegarding> wrapper, IColumnSet<Task> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetRegardingObjectId(this IEntityWrapperRelation<PostRegarding> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: regardingobjectowningbusinessunit. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetRegardingObjectOwningBusinessUnit(this IEntityWrapperRelation<PostRegarding> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectOwningBusinessUnit, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<PostRegarding> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectOwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<PostRegarding> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectOwnerId, columnSet);

    }
    public static class PostRoleExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetRegardingObjectId(this IEntityWrapperRelation<PostRole> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: appointment.
        /// </summary>
        public static IEntityWrapper<Appointment> GetRegardingObjectId(this IEntityWrapperRelation<PostRole> wrapper, IColumnSet<Appointment> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: competitor.
        /// </summary>
        public static IEntityWrapper<Competitor> GetRegardingObjectId(this IEntityWrapperRelation<PostRole> wrapper, IColumnSet<Competitor> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetRegardingObjectId(this IEntityWrapperRelation<PostRole> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetRegardingObjectId(this IEntityWrapperRelation<PostRole> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetRegardingObjectId(this IEntityWrapperRelation<PostRole> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetRegardingObjectId(this IEntityWrapperRelation<PostRole> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetRegardingObjectId(this IEntityWrapperRelation<PostRole> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: phonecall.
        /// </summary>
        public static IEntityWrapper<PhoneCall> GetRegardingObjectId(this IEntityWrapperRelation<PostRole> wrapper, IColumnSet<PhoneCall> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: processsession.
        /// </summary>
        public static IEntityWrapper<ProcessSession> GetRegardingObjectId(this IEntityWrapperRelation<PostRole> wrapper, IColumnSet<ProcessSession> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: queue.
        /// </summary>
        public static IEntityWrapper<Queue> GetRegardingObjectId(this IEntityWrapperRelation<PostRole> wrapper, IColumnSet<Queue> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: recurringappointmentmaster.
        /// </summary>
        public static IEntityWrapper<RecurringAppointmentMaster> GetRegardingObjectId(this IEntityWrapperRelation<PostRole> wrapper, IColumnSet<RecurringAppointmentMaster> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetRegardingObjectId(this IEntityWrapperRelation<PostRole> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: task.
        /// </summary>
        public static IEntityWrapper<Task> GetRegardingObjectId(this IEntityWrapperRelation<PostRole> wrapper, IColumnSet<Task> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetRegardingObjectId(this IEntityWrapperRelation<PostRole> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<PostRole> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: postid. Lookup to entity: post.
        /// </summary>
        public static IEntityWrapper<Post> GetPost(this IEntityWrapperRelation<PostRole> wrapper, IColumnSet<Post> columnSet)
            => wrapper.GetRelated(e => e.PostId, columnSet);

    }
    public static class PriceLevelExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<PriceLevel> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<PriceLevel> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class PrincipalObjectAttributeAccessExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: appointment.
        /// </summary>
        public static IEntityWrapper<Appointment> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Appointment> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bookableresource.
        /// </summary>
        public static IEntityWrapper<BookableResource> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<BookableResource> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bookableresourcebooking.
        /// </summary>
        public static IEntityWrapper<BookableResourceBooking> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<BookableResourceBooking> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bookableresourcebookingheader.
        /// </summary>
        public static IEntityWrapper<BookableResourceBookingHeader> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<BookableResourceBookingHeader> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bookableresourcecategory.
        /// </summary>
        public static IEntityWrapper<BookableResourceCategory> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<BookableResourceCategory> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bookableresourcecategoryassn.
        /// </summary>
        public static IEntityWrapper<BookableResourceCategoryAssn> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<BookableResourceCategoryAssn> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bookableresourcecharacteristic.
        /// </summary>
        public static IEntityWrapper<BookableResourceCharacteristic> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<BookableResourceCharacteristic> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bookableresourcegroup.
        /// </summary>
        public static IEntityWrapper<BookableResourceGroup> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<BookableResourceGroup> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bookingstatus.
        /// </summary>
        public static IEntityWrapper<BookingStatus> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<BookingStatus> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: campaignactivity.
        /// </summary>
        public static IEntityWrapper<CampaignActivity> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<CampaignActivity> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: campaignresponse.
        /// </summary>
        public static IEntityWrapper<CampaignResponse> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<CampaignResponse> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: channelaccessprofile.
        /// </summary>
        public static IEntityWrapper<ChannelAccessProfile> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<ChannelAccessProfile> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: characteristic.
        /// </summary>
        public static IEntityWrapper<Characteristic> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Characteristic> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: competitor.
        /// </summary>
        public static IEntityWrapper<Competitor> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Competitor> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: connection.
        /// </summary>
        public static IEntityWrapper<Connection> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Connection> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: contractdetail.
        /// </summary>
        public static IEntityWrapper<ContractDetail> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<ContractDetail> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: customeraddress.
        /// </summary>
        public static IEntityWrapper<CustomerAddress> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<CustomerAddress> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: email.
        /// </summary>
        public static IEntityWrapper<Email> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Email> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: entitlement.
        /// </summary>
        public static IEntityWrapper<Entitlement> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Entitlement> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: entitlementtemplate.
        /// </summary>
        public static IEntityWrapper<EntitlementTemplate> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<EntitlementTemplate> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: equipment.
        /// </summary>
        public static IEntityWrapper<Equipment> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Equipment> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: fax.
        /// </summary>
        public static IEntityWrapper<Fax> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Fax> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: feedback.
        /// </summary>
        public static IEntityWrapper<Feedback> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Feedback> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: goal.
        /// </summary>
        public static IEntityWrapper<Goal> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Goal> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: ins_salesorder.
        /// </summary>
        public static IEntityWrapper<ins_salesorder> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<ins_salesorder> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: ins_salesorderline.
        /// </summary>
        public static IEntityWrapper<ins_salesorderline> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<ins_salesorderline> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: invoice.
        /// </summary>
        public static IEntityWrapper<Invoice> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Invoice> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: invoicedetail.
        /// </summary>
        public static IEntityWrapper<InvoiceDetail> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<InvoiceDetail> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: kbarticle.
        /// </summary>
        public static IEntityWrapper<KbArticle> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<KbArticle> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: knowledgearticleincident.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticleIncident> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<KnowledgeArticleIncident> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: knowledgearticleviews.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticleViews> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<KnowledgeArticleViews> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: knowledgebaserecord.
        /// </summary>
        public static IEntityWrapper<KnowledgeBaseRecord> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<KnowledgeBaseRecord> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: letter.
        /// </summary>
        public static IEntityWrapper<Letter> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Letter> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: list.
        /// </summary>
        public static IEntityWrapper<List> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<List> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: mailmergetemplate.
        /// </summary>
        public static IEntityWrapper<MailMergeTemplate> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<MailMergeTemplate> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: msdyn_postalbum.
        /// </summary>
        public static IEntityWrapper<msdyn_PostAlbum> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<msdyn_PostAlbum> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: msdyn_postconfig.
        /// </summary>
        public static IEntityWrapper<msdyn_PostConfig> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<msdyn_PostConfig> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: msdyn_postruleconfig.
        /// </summary>
        public static IEntityWrapper<msdyn_PostRuleConfig> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<msdyn_PostRuleConfig> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: msdyn_wallsavedquery.
        /// </summary>
        public static IEntityWrapper<msdyn_wallsavedquery> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<msdyn_wallsavedquery> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: msdyn_wallsavedqueryusersettings.
        /// </summary>
        public static IEntityWrapper<msdyn_wallsavedqueryusersettings> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<msdyn_wallsavedqueryusersettings> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: opportunityproduct.
        /// </summary>
        public static IEntityWrapper<OpportunityProduct> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<OpportunityProduct> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: phonecall.
        /// </summary>
        public static IEntityWrapper<PhoneCall> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<PhoneCall> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: position.
        /// </summary>
        public static IEntityWrapper<Position> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Position> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: pricelevel.
        /// </summary>
        public static IEntityWrapper<PriceLevel> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<PriceLevel> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: productassociation.
        /// </summary>
        public static IEntityWrapper<ProductAssociation> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<ProductAssociation> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: productsubstitute.
        /// </summary>
        public static IEntityWrapper<ProductSubstitute> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<ProductSubstitute> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: queue.
        /// </summary>
        public static IEntityWrapper<Queue> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Queue> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: queueitem.
        /// </summary>
        public static IEntityWrapper<QueueItem> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<QueueItem> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: quotedetail.
        /// </summary>
        public static IEntityWrapper<QuoteDetail> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<QuoteDetail> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: ratingmodel.
        /// </summary>
        public static IEntityWrapper<RatingModel> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<RatingModel> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: ratingvalue.
        /// </summary>
        public static IEntityWrapper<RatingValue> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<RatingValue> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: recurringappointmentmaster.
        /// </summary>
        public static IEntityWrapper<RecurringAppointmentMaster> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<RecurringAppointmentMaster> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: reportcategory.
        /// </summary>
        public static IEntityWrapper<ReportCategory> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<ReportCategory> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: salesliterature.
        /// </summary>
        public static IEntityWrapper<SalesLiterature> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<SalesLiterature> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: salesorder.
        /// </summary>
        public static IEntityWrapper<SalesOrder> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<SalesOrder> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: salesorderdetail.
        /// </summary>
        public static IEntityWrapper<SalesOrderDetail> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<SalesOrderDetail> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: serviceappointment.
        /// </summary>
        public static IEntityWrapper<ServiceAppointment> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<ServiceAppointment> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: sharepointdocumentlocation.
        /// </summary>
        public static IEntityWrapper<SharePointDocumentLocation> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<SharePointDocumentLocation> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: sharepointsite.
        /// </summary>
        public static IEntityWrapper<SharePointSite> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<SharePointSite> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: socialactivity.
        /// </summary>
        public static IEntityWrapper<SocialActivity> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<SocialActivity> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: socialprofile.
        /// </summary>
        public static IEntityWrapper<SocialProfile> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<SocialProfile> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: task.
        /// </summary>
        public static IEntityWrapper<Task> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Task> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: territory.
        /// </summary>
        public static IEntityWrapper<Territory> GetEntityInstance(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Territory> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: principalid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetPrincipal(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.PrincipalId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: principalid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetPrincipal(this IEntityWrapperRelation<PrincipalObjectAttributeAccess> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.PrincipalId, columnSet);

    }
    public static class PrincipalSyncAttributeMapExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<PrincipalSyncAttributeMap> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: parentprincipalsyncattributemappingid. Lookup to entity: principalsyncattributemap.
        /// </summary>
        public static IEntityWrapper<PrincipalSyncAttributeMap> GetParentSyncAttributeMapping(this IEntityWrapperRelation<PrincipalSyncAttributeMap> wrapper, IColumnSet<PrincipalSyncAttributeMap> columnSet)
            => wrapper.GetRelated(e => e.ParentPrincipalSyncAttributeMappingId, columnSet);

    }
    public static class PrivilegeObjectTypeCodesExt
    {
        /// <summary>
        /// Related attribute: privilegeid. Lookup to entity: privilege.
        /// </summary>
        public static IEntityWrapper<Privilege> GetPrivilegeId(this IEntityWrapperRelation<PrivilegeObjectTypeCodes> wrapper, IColumnSet<Privilege> columnSet)
            => wrapper.GetRelated(e => e.PrivilegeId, columnSet);

    }
    public static class ProcessSessionExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: annotation.
        /// </summary>
        public static IEntityWrapper<Annotation> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Annotation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: appointment.
        /// </summary>
        public static IEntityWrapper<Appointment> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Appointment> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresource.
        /// </summary>
        public static IEntityWrapper<BookableResource> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<BookableResource> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebooking.
        /// </summary>
        public static IEntityWrapper<BookableResourceBooking> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<BookableResourceBooking> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebookingheader.
        /// </summary>
        public static IEntityWrapper<BookableResourceBookingHeader> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<BookableResourceBookingHeader> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcecategory.
        /// </summary>
        public static IEntityWrapper<BookableResourceCategory> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<BookableResourceCategory> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcecategoryassn.
        /// </summary>
        public static IEntityWrapper<BookableResourceCategoryAssn> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<BookableResourceCategoryAssn> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcecharacteristic.
        /// </summary>
        public static IEntityWrapper<BookableResourceCharacteristic> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<BookableResourceCharacteristic> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcegroup.
        /// </summary>
        public static IEntityWrapper<BookableResourceGroup> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<BookableResourceGroup> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookingstatus.
        /// </summary>
        public static IEntityWrapper<BookingStatus> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<BookingStatus> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: businessunitnewsarticle.
        /// </summary>
        public static IEntityWrapper<BusinessUnitNewsArticle> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<BusinessUnitNewsArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaignactivity.
        /// </summary>
        public static IEntityWrapper<CampaignActivity> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<CampaignActivity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaignresponse.
        /// </summary>
        public static IEntityWrapper<CampaignResponse> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<CampaignResponse> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: channelaccessprofile.
        /// </summary>
        public static IEntityWrapper<ChannelAccessProfile> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<ChannelAccessProfile> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: channelaccessprofilerule.
        /// </summary>
        public static IEntityWrapper<ChannelAccessProfileRule> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<ChannelAccessProfileRule> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: characteristic.
        /// </summary>
        public static IEntityWrapper<Characteristic> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Characteristic> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: competitor.
        /// </summary>
        public static IEntityWrapper<Competitor> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Competitor> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: connection.
        /// </summary>
        public static IEntityWrapper<Connection> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Connection> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: connectionrole.
        /// </summary>
        public static IEntityWrapper<ConnectionRole> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<ConnectionRole> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: constraintbasedgroup.
        /// </summary>
        public static IEntityWrapper<ConstraintBasedGroup> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<ConstraintBasedGroup> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contractdetail.
        /// </summary>
        public static IEntityWrapper<ContractDetail> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<ContractDetail> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contracttemplate.
        /// </summary>
        public static IEntityWrapper<ContractTemplate> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<ContractTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: convertrule.
        /// </summary>
        public static IEntityWrapper<ConvertRule> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<ConvertRule> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: customeraddress.
        /// </summary>
        public static IEntityWrapper<CustomerAddress> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<CustomerAddress> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: customeropportunityrole.
        /// </summary>
        public static IEntityWrapper<CustomerOpportunityRole> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<CustomerOpportunityRole> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: customerrelationship.
        /// </summary>
        public static IEntityWrapper<CustomerRelationship> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<CustomerRelationship> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: discount.
        /// </summary>
        public static IEntityWrapper<Discount> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Discount> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: discounttype.
        /// </summary>
        public static IEntityWrapper<DiscountType> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<DiscountType> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: email.
        /// </summary>
        public static IEntityWrapper<Email> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Email> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlement.
        /// </summary>
        public static IEntityWrapper<Entitlement> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Entitlement> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlementchannel.
        /// </summary>
        public static IEntityWrapper<EntitlementChannel> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<EntitlementChannel> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlementtemplate.
        /// </summary>
        public static IEntityWrapper<EntitlementTemplate> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<EntitlementTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: equipment.
        /// </summary>
        public static IEntityWrapper<Equipment> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Equipment> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: externalpartyitem.
        /// </summary>
        public static IEntityWrapper<ExternalPartyItem> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<ExternalPartyItem> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: fax.
        /// </summary>
        public static IEntityWrapper<Fax> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Fax> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: goal.
        /// </summary>
        public static IEntityWrapper<Goal> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Goal> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: goalrollupquery.
        /// </summary>
        public static IEntityWrapper<GoalRollupQuery> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<GoalRollupQuery> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: ins_salesorder.
        /// </summary>
        public static IEntityWrapper<ins_salesorder> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<ins_salesorder> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: ins_salesorderline.
        /// </summary>
        public static IEntityWrapper<ins_salesorderline> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<ins_salesorderline> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: invoice.
        /// </summary>
        public static IEntityWrapper<Invoice> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Invoice> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: invoicedetail.
        /// </summary>
        public static IEntityWrapper<InvoiceDetail> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<InvoiceDetail> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: kbarticle.
        /// </summary>
        public static IEntityWrapper<KbArticle> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<KbArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: kbarticlecomment.
        /// </summary>
        public static IEntityWrapper<KbArticleComment> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<KbArticleComment> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: kbarticletemplate.
        /// </summary>
        public static IEntityWrapper<KbArticleTemplate> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<KbArticleTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgebaserecord.
        /// </summary>
        public static IEntityWrapper<KnowledgeBaseRecord> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<KnowledgeBaseRecord> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: letter.
        /// </summary>
        public static IEntityWrapper<Letter> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Letter> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: list.
        /// </summary>
        public static IEntityWrapper<List> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<List> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: mailbox.
        /// </summary>
        public static IEntityWrapper<Mailbox> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Mailbox> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: mailmergetemplate.
        /// </summary>
        public static IEntityWrapper<MailMergeTemplate> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<MailMergeTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: metric.
        /// </summary>
        public static IEntityWrapper<Metric> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Metric> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_postalbum.
        /// </summary>
        public static IEntityWrapper<msdyn_PostAlbum> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<msdyn_PostAlbum> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_postconfig.
        /// </summary>
        public static IEntityWrapper<msdyn_PostConfig> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<msdyn_PostConfig> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_postruleconfig.
        /// </summary>
        public static IEntityWrapper<msdyn_PostRuleConfig> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<msdyn_PostRuleConfig> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_wallsavedquery.
        /// </summary>
        public static IEntityWrapper<msdyn_wallsavedquery> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<msdyn_wallsavedquery> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_wallsavedqueryusersettings.
        /// </summary>
        public static IEntityWrapper<msdyn_wallsavedqueryusersettings> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<msdyn_wallsavedqueryusersettings> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunityproduct.
        /// </summary>
        public static IEntityWrapper<OpportunityProduct> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<OpportunityProduct> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: phonecall.
        /// </summary>
        public static IEntityWrapper<PhoneCall> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<PhoneCall> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: position.
        /// </summary>
        public static IEntityWrapper<Position> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Position> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: pricelevel.
        /// </summary>
        public static IEntityWrapper<PriceLevel> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<PriceLevel> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: productassociation.
        /// </summary>
        public static IEntityWrapper<ProductAssociation> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<ProductAssociation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: productpricelevel.
        /// </summary>
        public static IEntityWrapper<ProductPriceLevel> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<ProductPriceLevel> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: productsubstitute.
        /// </summary>
        public static IEntityWrapper<ProductSubstitute> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<ProductSubstitute> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: queue.
        /// </summary>
        public static IEntityWrapper<Queue> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Queue> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: queueitem.
        /// </summary>
        public static IEntityWrapper<QueueItem> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<QueueItem> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quotedetail.
        /// </summary>
        public static IEntityWrapper<QuoteDetail> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<QuoteDetail> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: ratingmodel.
        /// </summary>
        public static IEntityWrapper<RatingModel> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<RatingModel> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: ratingvalue.
        /// </summary>
        public static IEntityWrapper<RatingValue> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<RatingValue> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: recurringappointmentmaster.
        /// </summary>
        public static IEntityWrapper<RecurringAppointmentMaster> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<RecurringAppointmentMaster> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: relationshiprole.
        /// </summary>
        public static IEntityWrapper<RelationshipRole> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<RelationshipRole> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: report.
        /// </summary>
        public static IEntityWrapper<Report> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Report> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: rollupfield.
        /// </summary>
        public static IEntityWrapper<RollupField> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<RollupField> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: routingrule.
        /// </summary>
        public static IEntityWrapper<RoutingRule> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<RoutingRule> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: routingruleitem.
        /// </summary>
        public static IEntityWrapper<RoutingRuleItem> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<RoutingRuleItem> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesliterature.
        /// </summary>
        public static IEntityWrapper<SalesLiterature> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<SalesLiterature> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesliteratureitem.
        /// </summary>
        public static IEntityWrapper<SalesLiteratureItem> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<SalesLiteratureItem> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesorder.
        /// </summary>
        public static IEntityWrapper<SalesOrder> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<SalesOrder> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesorderdetail.
        /// </summary>
        public static IEntityWrapper<SalesOrderDetail> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<SalesOrderDetail> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: service.
        /// </summary>
        public static IEntityWrapper<Service> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Service> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: serviceappointment.
        /// </summary>
        public static IEntityWrapper<ServiceAppointment> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<ServiceAppointment> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: sharepointdocumentlocation.
        /// </summary>
        public static IEntityWrapper<SharePointDocumentLocation> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<SharePointDocumentLocation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: sharepointsite.
        /// </summary>
        public static IEntityWrapper<SharePointSite> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<SharePointSite> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: site.
        /// </summary>
        public static IEntityWrapper<Site> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Site> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: socialactivity.
        /// </summary>
        public static IEntityWrapper<SocialActivity> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<SocialActivity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: socialprofile.
        /// </summary>
        public static IEntityWrapper<SocialProfile> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<SocialProfile> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: subject.
        /// </summary>
        public static IEntityWrapper<Subject> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Subject> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: task.
        /// </summary>
        public static IEntityWrapper<Task> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Task> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: template.
        /// </summary>
        public static IEntityWrapper<Template> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Template> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: territory.
        /// </summary>
        public static IEntityWrapper<Territory> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Territory> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: theme.
        /// </summary>
        public static IEntityWrapper<Theme> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Theme> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: usermapping.
        /// </summary>
        public static IEntityWrapper<UserMapping> GetRegarding(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<UserMapping> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: nextlinkedsessionid. Lookup to entity: processsession.
        /// </summary>
        public static IEntityWrapper<ProcessSession> GetNextLinkedSession(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<ProcessSession> columnSet)
            => wrapper.GetRelated(e => e.NextLinkedSessionId, columnSet);
        /// <summary>
        /// Related attribute: originatingsessionid. Lookup to entity: processsession.
        /// </summary>
        public static IEntityWrapper<ProcessSession> GetOriginatingSession(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<ProcessSession> columnSet)
            => wrapper.GetRelated(e => e.OriginatingSessionId, columnSet);
        /// <summary>
        /// Related attribute: previouslinkedsessionid. Lookup to entity: processsession.
        /// </summary>
        public static IEntityWrapper<ProcessSession> GetPreviousLinkedSession(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<ProcessSession> columnSet)
            => wrapper.GetRelated(e => e.PreviousLinkedSessionId, columnSet);
        /// <summary>
        /// Related attribute: canceledby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCanceledBy(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CanceledBy, columnSet);
        /// <summary>
        /// Related attribute: completedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCompletedBy(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CompletedBy, columnSet);
        /// <summary>
        /// Related attribute: executedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetExecutedBy(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ExecutedBy, columnSet);
        /// <summary>
        /// Related attribute: startedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetStartedBy(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.StartedBy, columnSet);
        /// <summary>
        /// Related attribute: processid. Lookup to entity: workflow.
        /// </summary>
        public static IEntityWrapper<Workflow> GetProcess(this IEntityWrapperRelation<ProcessSession> wrapper, IColumnSet<Workflow> columnSet)
            => wrapper.GetRelated(e => e.ProcessId, columnSet);

    }
    public static class ProcessStageExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<ProcessStage> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<ProcessStage> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Related attribute: processid. Lookup to entity: workflow.
        /// </summary>
        public static IEntityWrapper<Workflow> GetProcess(this IEntityWrapperRelation<ProcessStage> wrapper, IColumnSet<Workflow> columnSet)
            => wrapper.GetRelated(e => e.ProcessId, columnSet);

    }
    public static class ProcessTriggerExt
    {
        /// <summary>
        /// Related attribute: formid. Lookup to entity: systemform.
        /// </summary>
        public static IEntityWrapper<SystemForm> GetForm(this IEntityWrapperRelation<ProcessTrigger> wrapper, IColumnSet<SystemForm> columnSet)
            => wrapper.GetRelated(e => e.FormId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<ProcessTrigger> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<ProcessTrigger> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<ProcessTrigger> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<ProcessTrigger> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<ProcessTrigger> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<ProcessTrigger> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Related attribute: processid. Lookup to entity: workflow.
        /// </summary>
        public static IEntityWrapper<Workflow> GetProcess(this IEntityWrapperRelation<ProcessTrigger> wrapper, IColumnSet<Workflow> columnSet)
            => wrapper.GetRelated(e => e.ProcessId, columnSet);

    }
    public static class ProductExt
    {
        /// <summary>
        /// Related attribute: createdbyexternalparty. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetCreatedByExternalParty(this IEntityWrapperRelation<Product> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.CreatedByExternalParty, columnSet);
        /// <summary>
        /// Related attribute: modifiedbyexternalparty. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetModifiedByExternalParty(this IEntityWrapperRelation<Product> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.ModifiedByExternalParty, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<Product> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: pricelevelid. Lookup to entity: pricelevel.
        /// </summary>
        public static IEntityWrapper<PriceLevel> GetDefaultPriceList(this IEntityWrapperRelation<Product> wrapper, IColumnSet<PriceLevel> columnSet)
            => wrapper.GetRelated(e => e.PriceLevelId, columnSet);
        /// <summary>
        /// Related attribute: parentproductid. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetParent(this IEntityWrapperRelation<Product> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.ParentProductId, columnSet);
        /// <summary>
        /// Related attribute: subjectid. Lookup to entity: subject.
        /// </summary>
        public static IEntityWrapper<Subject> GetSubject(this IEntityWrapperRelation<Product> wrapper, IColumnSet<Subject> columnSet)
            => wrapper.GetRelated(e => e.SubjectId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Product> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);
        /// <summary>
        /// Related attribute: defaultuomid. Lookup to entity: uom.
        /// </summary>
        public static IEntityWrapper<UoM> GetDefaultUnit(this IEntityWrapperRelation<Product> wrapper, IColumnSet<UoM> columnSet)
            => wrapper.GetRelated(e => e.DefaultUoMId, columnSet);
        /// <summary>
        /// Related attribute: defaultuomscheduleid. Lookup to entity: uomschedule.
        /// </summary>
        public static IEntityWrapper<UoMSchedule> GetUnitGroup(this IEntityWrapperRelation<Product> wrapper, IColumnSet<UoMSchedule> columnSet)
            => wrapper.GetRelated(e => e.DefaultUoMScheduleId, columnSet);

    }
    public static class ProductAssociationExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<ProductAssociation> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: associatedproduct. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetAssociatedProduct(this IEntityWrapperRelation<ProductAssociation> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.AssociatedProduct, columnSet);
        /// <summary>
        /// Related attribute: productid. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetProduct(this IEntityWrapperRelation<ProductAssociation> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.ProductId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<ProductAssociation> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);
        /// <summary>
        /// Related attribute: uomid. Lookup to entity: uom.
        /// </summary>
        public static IEntityWrapper<UoM> GetUnit(this IEntityWrapperRelation<ProductAssociation> wrapper, IColumnSet<UoM> columnSet)
            => wrapper.GetRelated(e => e.UoMId, columnSet);

    }
    public static class ProductPriceLevelExt
    {
        /// <summary>
        /// Related attribute: discounttypeid. Lookup to entity: discounttype.
        /// </summary>
        public static IEntityWrapper<DiscountType> GetDiscountList(this IEntityWrapperRelation<ProductPriceLevel> wrapper, IColumnSet<DiscountType> columnSet)
            => wrapper.GetRelated(e => e.DiscountTypeId, columnSet);
        /// <summary>
        /// Related attribute: pricelevelid. Lookup to entity: pricelevel.
        /// </summary>
        public static IEntityWrapper<PriceLevel> GetPriceList(this IEntityWrapperRelation<ProductPriceLevel> wrapper, IColumnSet<PriceLevel> columnSet)
            => wrapper.GetRelated(e => e.PriceLevelId, columnSet);
        /// <summary>
        /// Related attribute: productid. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetProduct(this IEntityWrapperRelation<ProductPriceLevel> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.ProductId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<ProductPriceLevel> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<ProductPriceLevel> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<ProductPriceLevel> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<ProductPriceLevel> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<ProductPriceLevel> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);
        /// <summary>
        /// Related attribute: uomid. Lookup to entity: uom.
        /// </summary>
        public static IEntityWrapper<UoM> GetUnit(this IEntityWrapperRelation<ProductPriceLevel> wrapper, IColumnSet<UoM> columnSet)
            => wrapper.GetRelated(e => e.UoMId, columnSet);
        /// <summary>
        /// Related attribute: uomscheduleid. Lookup to entity: uomschedule.
        /// </summary>
        public static IEntityWrapper<UoMSchedule> GetUnitScheduleID(this IEntityWrapperRelation<ProductPriceLevel> wrapper, IColumnSet<UoMSchedule> columnSet)
            => wrapper.GetRelated(e => e.UoMScheduleId, columnSet);

    }
    public static class ProductSubstituteExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<ProductSubstitute> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: productid. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetProduct(this IEntityWrapperRelation<ProductSubstitute> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.ProductId, columnSet);
        /// <summary>
        /// Related attribute: substitutedproductid. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetRelatedProduct(this IEntityWrapperRelation<ProductSubstitute> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.SubstitutedProductId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<ProductSubstitute> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class PublisherExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<Publisher> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class PublisherAddressExt
    {
        /// <summary>
        /// Related attribute: parentid. Lookup to entity: publisher.
        /// </summary>
        public static IEntityWrapper<Publisher> GetParent(this IEntityWrapperRelation<PublisherAddress> wrapper, IColumnSet<Publisher> columnSet)
            => wrapper.GetRelated(e => e.ParentId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<PublisherAddress> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<PublisherAddress> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<PublisherAddress> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<PublisherAddress> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);

    }
    public static class QuarterlyFiscalCalendarExt
    {
        /// <summary>
        /// Related attribute: businessunitid. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetBusinessUnitId(this IEntityWrapperRelation<QuarterlyFiscalCalendar> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.BusinessUnitId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<QuarterlyFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<QuarterlyFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<QuarterlyFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<QuarterlyFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: salespersonid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetSalesPersonId(this IEntityWrapperRelation<QuarterlyFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.SalesPersonId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<QuarterlyFiscalCalendar> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class QueueExt
    {
        /// <summary>
        /// Related attribute: businessunitid. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetBusinessUnit(this IEntityWrapperRelation<Queue> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.BusinessUnitId, columnSet);
        /// <summary>
        /// Related attribute: defaultmailbox. Lookup to entity: mailbox.
        /// </summary>
        public static IEntityWrapper<Mailbox> GetMailbox(this IEntityWrapperRelation<Queue> wrapper, IColumnSet<Mailbox> columnSet)
            => wrapper.GetRelated(e => e.DefaultMailbox, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<Queue> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: primaryuserid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwnerDeprecated(this IEntityWrapperRelation<Queue> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.PrimaryUserId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Queue> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class QueueItemExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: activitypointer.
        /// </summary>
        public static IEntityWrapper<ActivityPointer> GetObject(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<ActivityPointer> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: appointment.
        /// </summary>
        public static IEntityWrapper<Appointment> GetObject(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<Appointment> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bulkoperation.
        /// </summary>
        public static IEntityWrapper<BulkOperation> GetObject(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<BulkOperation> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: campaignactivity.
        /// </summary>
        public static IEntityWrapper<CampaignActivity> GetObject(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<CampaignActivity> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: campaignresponse.
        /// </summary>
        public static IEntityWrapper<CampaignResponse> GetObject(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<CampaignResponse> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: email.
        /// </summary>
        public static IEntityWrapper<Email> GetObject(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<Email> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: fax.
        /// </summary>
        public static IEntityWrapper<Fax> GetObject(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<Fax> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetObject(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetObject(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: letter.
        /// </summary>
        public static IEntityWrapper<Letter> GetObject(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<Letter> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: phonecall.
        /// </summary>
        public static IEntityWrapper<PhoneCall> GetObject(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<PhoneCall> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: recurringappointmentmaster.
        /// </summary>
        public static IEntityWrapper<RecurringAppointmentMaster> GetObject(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<RecurringAppointmentMaster> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: serviceappointment.
        /// </summary>
        public static IEntityWrapper<ServiceAppointment> GetObject(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<ServiceAppointment> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: socialactivity.
        /// </summary>
        public static IEntityWrapper<SocialActivity> GetObject(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<SocialActivity> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: task.
        /// </summary>
        public static IEntityWrapper<Task> GetObject(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<Task> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Related attribute: owningbusinessunit. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetOwningBusinessUnit(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.OwningBusinessUnit, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: queueid. Lookup to entity: queue.
        /// </summary>
        public static IEntityWrapper<Queue> GetQueue(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<Queue> columnSet)
            => wrapper.GetRelated(e => e.QueueId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Related attribute: owninguser. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwningUser(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwningUser, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: workerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetWorkedBy(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.WorkerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: workerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetWorkedBy(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.WorkerId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<QueueItem> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class QuoteExt
    {
        /// <summary>
        /// Related attribute: accountid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetAccount(this IEntityWrapperRelation<Quote> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.AccountId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: customerid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetPotentialCustomer(this IEntityWrapperRelation<Quote> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.CustomerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: customerid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetPotentialCustomer(this IEntityWrapperRelation<Quote> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.CustomerId, columnSet);
        /// <summary>
        /// Related attribute: campaignid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetSourceCampaign(this IEntityWrapperRelation<Quote> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.CampaignId, columnSet);
        /// <summary>
        /// Related attribute: contactid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetContact(this IEntityWrapperRelation<Quote> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.ContactId, columnSet);
        /// <summary>
        /// Related attribute: opportunityid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetOpportunity(this IEntityWrapperRelation<Quote> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.OpportunityId, columnSet);
        /// <summary>
        /// Related attribute: pricelevelid. Lookup to entity: pricelevel.
        /// </summary>
        public static IEntityWrapper<PriceLevel> GetPriceList(this IEntityWrapperRelation<Quote> wrapper, IColumnSet<PriceLevel> columnSet)
            => wrapper.GetRelated(e => e.PriceLevelId, columnSet);
        /// <summary>
        /// Related attribute: slaid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetSLA(this IEntityWrapperRelation<Quote> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAId, columnSet);
        /// <summary>
        /// Related attribute: slainvokedid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetLastSLAApplied(this IEntityWrapperRelation<Quote> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAInvokedId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Quote> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class QuoteCloseExt
    {
        /// <summary>
        /// Related attribute: createdbyexternalparty. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetCreatedByExternalParty(this IEntityWrapperRelation<QuoteClose> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.CreatedByExternalParty, columnSet);
        /// <summary>
        /// Related attribute: modifiedbyexternalparty. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetModifiedByExternalParty(this IEntityWrapperRelation<QuoteClose> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.ModifiedByExternalParty, columnSet);
        /// <summary>
        /// Related attribute: quoteid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetQuote(this IEntityWrapperRelation<QuoteClose> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.QuoteId, columnSet);
        /// <summary>
        /// Related attribute: serviceid. Lookup to entity: service.
        /// </summary>
        public static IEntityWrapper<Service> GetService(this IEntityWrapperRelation<QuoteClose> wrapper, IColumnSet<Service> columnSet)
            => wrapper.GetRelated(e => e.ServiceId, columnSet);

    }
    public static class QuoteDetailExt
    {
        /// <summary>
        /// Related attribute: productid. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetExistingProduct(this IEntityWrapperRelation<QuoteDetail> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.ProductId, columnSet);
        /// <summary>
        /// Related attribute: quoteid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetQuote(this IEntityWrapperRelation<QuoteDetail> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.QuoteId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<QuoteDetail> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<QuoteDetail> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<QuoteDetail> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<QuoteDetail> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<QuoteDetail> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<QuoteDetail> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Related attribute: salesrepid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetSalesperson(this IEntityWrapperRelation<QuoteDetail> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.SalesRepId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<QuoteDetail> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);
        /// <summary>
        /// Related attribute: uomid. Lookup to entity: uom.
        /// </summary>
        public static IEntityWrapper<UoM> GetUnit(this IEntityWrapperRelation<QuoteDetail> wrapper, IColumnSet<UoM> columnSet)
            => wrapper.GetRelated(e => e.UoMId, columnSet);

    }
    public static class RatingModelExt
    {
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<RatingModel> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class RatingValueExt
    {
        /// <summary>
        /// Related attribute: ratingmodel. Lookup to entity: ratingmodel.
        /// </summary>
        public static IEntityWrapper<RatingModel> GetRatingModel(this IEntityWrapperRelation<RatingValue> wrapper, IColumnSet<RatingModel> columnSet)
            => wrapper.GetRelated(e => e.RatingModel, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<RatingValue> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class RecommendationCacheExt
    {
        /// <summary>
        /// Related attribute: itemid. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetProduct(this IEntityWrapperRelation<RecommendationCache> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.ItemId, columnSet);
        /// <summary>
        /// Related attribute: recommendeditemid. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetRecommendedProduct(this IEntityWrapperRelation<RecommendationCache> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.RecommendedItemId, columnSet);
        /// <summary>
        /// Related attribute: additionaldatarecordid. Lookup to entity: productpricelevel.
        /// </summary>
        public static IEntityWrapper<ProductPriceLevel> GetProductDetails(this IEntityWrapperRelation<RecommendationCache> wrapper, IColumnSet<ProductPriceLevel> columnSet)
            => wrapper.GetRelated(e => e.AdditionalDataRecordId, columnSet);
        /// <summary>
        /// Related attribute: recommendationmodelid. Lookup to entity: recommendationmodel.
        /// </summary>
        public static IEntityWrapper<RecommendationModel> GetRecommendationModel(this IEntityWrapperRelation<RecommendationCache> wrapper, IColumnSet<RecommendationModel> columnSet)
            => wrapper.GetRelated(e => e.RecommendationModelId, columnSet);

    }
    public static class RecommendationModelExt
    {
        /// <summary>
        /// Related attribute: azureserviceconnectionid. Lookup to entity: azureserviceconnection.
        /// </summary>
        public static IEntityWrapper<AzureServiceConnection> GetAzureServiceConnection(this IEntityWrapperRelation<RecommendationModel> wrapper, IColumnSet<AzureServiceConnection> columnSet)
            => wrapper.GetRelated(e => e.AzureServiceConnectionId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<RecommendationModel> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: recommendationmodelversionid. Lookup to entity: recommendationmodelversion.
        /// </summary>
        public static IEntityWrapper<RecommendationModelVersion> GetRecommendationVersion(this IEntityWrapperRelation<RecommendationModel> wrapper, IColumnSet<RecommendationModelVersion> columnSet)
            => wrapper.GetRelated(e => e.RecommendationModelVersionId, columnSet);

    }
    public static class RecommendationModelMappingExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<RecommendationModelMapping> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: recommendationmodelid. Lookup to entity: recommendationmodel.
        /// </summary>
        public static IEntityWrapper<RecommendationModel> GetRecommendationModel(this IEntityWrapperRelation<RecommendationModelMapping> wrapper, IColumnSet<RecommendationModel> columnSet)
            => wrapper.GetRelated(e => e.RecommendationModelId, columnSet);
        /// <summary>
        /// Related attribute: supportedmapid. Lookup to entity: recommendationmodelmapping.
        /// </summary>
        public static IEntityWrapper<RecommendationModelMapping> GetAssociatedRecommendationMapping(this IEntityWrapperRelation<RecommendationModelMapping> wrapper, IColumnSet<RecommendationModelMapping> columnSet)
            => wrapper.GetRelated(e => e.SupportedMapId, columnSet);
        /// <summary>
        /// Related attribute: recommendationmodelversionid. Lookup to entity: recommendationmodelversion.
        /// </summary>
        public static IEntityWrapper<RecommendationModelVersion> GetModelVersion(this IEntityWrapperRelation<RecommendationModelMapping> wrapper, IColumnSet<RecommendationModelVersion> columnSet)
            => wrapper.GetRelated(e => e.RecommendationModelVersionId, columnSet);

    }
    public static class RecommendationModelVersionExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<RecommendationModelVersion> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: recommendationmodelid. Lookup to entity: recommendationmodel.
        /// </summary>
        public static IEntityWrapper<RecommendationModel> GetRecommendationModelId(this IEntityWrapperRelation<RecommendationModelVersion> wrapper, IColumnSet<RecommendationModel> columnSet)
            => wrapper.GetRelated(e => e.RecommendationModelId, columnSet);

    }
    public static class RecommendationModelVersionHistoryExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<RecommendationModelVersionHistory> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: recommendationmodelversionid. Lookup to entity: recommendationmodelversion.
        /// </summary>
        public static IEntityWrapper<RecommendationModelVersion> GetRecommendationModelVersion(this IEntityWrapperRelation<RecommendationModelVersionHistory> wrapper, IColumnSet<RecommendationModelVersion> columnSet)
            => wrapper.GetRelated(e => e.RecommendationModelVersionId, columnSet);

    }
    public static class RecommendedDocumentExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationID(this IEntityWrapperRelation<RecommendedDocument> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<RecommendedDocument> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class RecurrenceRuleExt
    {
        /// <summary>
        /// Related attribute: objectid. Lookup to entity: activitypointer.
        /// </summary>
        public static IEntityWrapper<ActivityPointer> GetRegarding(this IEntityWrapperRelation<RecurrenceRule> wrapper, IColumnSet<ActivityPointer> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);

    }
    public static class RecurringAppointmentMasterExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetRegarding(this IEntityWrapperRelation<RecurringAppointmentMaster> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebooking.
        /// </summary>
        public static IEntityWrapper<BookableResourceBooking> GetRegarding(this IEntityWrapperRelation<RecurringAppointmentMaster> wrapper, IColumnSet<BookableResourceBooking> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebookingheader.
        /// </summary>
        public static IEntityWrapper<BookableResourceBookingHeader> GetRegarding(this IEntityWrapperRelation<RecurringAppointmentMaster> wrapper, IColumnSet<BookableResourceBookingHeader> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bulkoperation.
        /// </summary>
        public static IEntityWrapper<BulkOperation> GetRegarding(this IEntityWrapperRelation<RecurringAppointmentMaster> wrapper, IColumnSet<BulkOperation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetRegarding(this IEntityWrapperRelation<RecurringAppointmentMaster> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaignactivity.
        /// </summary>
        public static IEntityWrapper<CampaignActivity> GetRegarding(this IEntityWrapperRelation<RecurringAppointmentMaster> wrapper, IColumnSet<CampaignActivity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetRegarding(this IEntityWrapperRelation<RecurringAppointmentMaster> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetRegarding(this IEntityWrapperRelation<RecurringAppointmentMaster> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlement.
        /// </summary>
        public static IEntityWrapper<Entitlement> GetRegarding(this IEntityWrapperRelation<RecurringAppointmentMaster> wrapper, IColumnSet<Entitlement> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlementtemplate.
        /// </summary>
        public static IEntityWrapper<EntitlementTemplate> GetRegarding(this IEntityWrapperRelation<RecurringAppointmentMaster> wrapper, IColumnSet<EntitlementTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetRegarding(this IEntityWrapperRelation<RecurringAppointmentMaster> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: invoice.
        /// </summary>
        public static IEntityWrapper<Invoice> GetRegarding(this IEntityWrapperRelation<RecurringAppointmentMaster> wrapper, IColumnSet<Invoice> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetRegarding(this IEntityWrapperRelation<RecurringAppointmentMaster> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgebaserecord.
        /// </summary>
        public static IEntityWrapper<KnowledgeBaseRecord> GetRegarding(this IEntityWrapperRelation<RecurringAppointmentMaster> wrapper, IColumnSet<KnowledgeBaseRecord> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetRegarding(this IEntityWrapperRelation<RecurringAppointmentMaster> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_postalbum.
        /// </summary>
        public static IEntityWrapper<msdyn_PostAlbum> GetRegarding(this IEntityWrapperRelation<RecurringAppointmentMaster> wrapper, IColumnSet<msdyn_PostAlbum> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetRegarding(this IEntityWrapperRelation<RecurringAppointmentMaster> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetRegarding(this IEntityWrapperRelation<RecurringAppointmentMaster> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesorder.
        /// </summary>
        public static IEntityWrapper<SalesOrder> GetRegarding(this IEntityWrapperRelation<RecurringAppointmentMaster> wrapper, IColumnSet<SalesOrder> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: ruleid. Lookup to entity: recurrencerule.
        /// </summary>
        public static IEntityWrapper<RecurrenceRule> GetRecurrenceRule(this IEntityWrapperRelation<RecurringAppointmentMaster> wrapper, IColumnSet<RecurrenceRule> columnSet)
            => wrapper.GetRelated(e => e.RuleId, columnSet);
        /// <summary>
        /// Related attribute: groupid. Lookup to entity: recurringappointmentmaster.
        /// </summary>
        public static IEntityWrapper<RecurringAppointmentMaster> GetGroupId(this IEntityWrapperRelation<RecurringAppointmentMaster> wrapper, IColumnSet<RecurringAppointmentMaster> columnSet)
            => wrapper.GetRelated(e => e.GroupId, columnSet);
        /// <summary>
        /// Related attribute: serviceid. Lookup to entity: service.
        /// </summary>
        public static IEntityWrapper<Service> GetService(this IEntityWrapperRelation<RecurringAppointmentMaster> wrapper, IColumnSet<Service> columnSet)
            => wrapper.GetRelated(e => e.ServiceId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<RecurringAppointmentMaster> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class RelationshipRoleExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<RelationshipRole> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class RelationshipRoleMapExt
    {
        /// <summary>
        /// Related attribute: relationshiproleid. Lookup to entity: relationshiprole.
        /// </summary>
        public static IEntityWrapper<RelationshipRole> GetRelationshipRoleId(this IEntityWrapperRelation<RelationshipRoleMap> wrapper, IColumnSet<RelationshipRole> columnSet)
            => wrapper.GetRelated(e => e.RelationshipRoleId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<RelationshipRoleMap> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<RelationshipRoleMap> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<RelationshipRoleMap> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<RelationshipRoleMap> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);

    }
    public static class ReplicationBacklogExt
    {
        /// <summary>
        /// Related attribute: targetobjectid. Lookup to entity: report.
        /// </summary>
        public static IEntityWrapper<Report> GetTargetObjectId(this IEntityWrapperRelation<ReplicationBacklog> wrapper, IColumnSet<Report> columnSet)
            => wrapper.GetRelated(e => e.TargetObjectId, columnSet);

    }
    public static class ReportExt
    {
        /// <summary>
        /// Related attribute: parentreportid. Lookup to entity: report.
        /// </summary>
        public static IEntityWrapper<Report> GetParentReport(this IEntityWrapperRelation<Report> wrapper, IColumnSet<Report> columnSet)
            => wrapper.GetRelated(e => e.ParentReportId, columnSet);

    }
    public static class ReportCategoryExt
    {
        /// <summary>
        /// Related attribute: reportid. Lookup to entity: report.
        /// </summary>
        public static IEntityWrapper<Report> GetReport(this IEntityWrapperRelation<ReportCategory> wrapper, IColumnSet<Report> columnSet)
            => wrapper.GetRelated(e => e.ReportId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<ReportCategory> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<ReportCategory> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<ReportCategory> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<ReportCategory> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<ReportCategory> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<ReportCategory> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<ReportCategory> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class ReportEntityExt
    {
        /// <summary>
        /// Related attribute: reportid. Lookup to entity: report.
        /// </summary>
        public static IEntityWrapper<Report> GetReport(this IEntityWrapperRelation<ReportEntity> wrapper, IColumnSet<Report> columnSet)
            => wrapper.GetRelated(e => e.ReportId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<ReportEntity> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<ReportEntity> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<ReportEntity> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<ReportEntity> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<ReportEntity> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<ReportEntity> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);

    }
    public static class ReportLinkExt
    {
        /// <summary>
        /// Related attribute: linkedreportid. Lookup to entity: report.
        /// </summary>
        public static IEntityWrapper<Report> GetLinkedReport(this IEntityWrapperRelation<ReportLink> wrapper, IColumnSet<Report> columnSet)
            => wrapper.GetRelated(e => e.LinkedReportId, columnSet);
        /// <summary>
        /// Related attribute: reportid. Lookup to entity: report.
        /// </summary>
        public static IEntityWrapper<Report> GetMainReport(this IEntityWrapperRelation<ReportLink> wrapper, IColumnSet<Report> columnSet)
            => wrapper.GetRelated(e => e.ReportId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<ReportLink> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<ReportLink> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<ReportLink> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<ReportLink> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<ReportLink> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<ReportLink> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);

    }
    public static class ReportVisibilityExt
    {
        /// <summary>
        /// Related attribute: reportid. Lookup to entity: report.
        /// </summary>
        public static IEntityWrapper<Report> GetReport(this IEntityWrapperRelation<ReportVisibility> wrapper, IColumnSet<Report> columnSet)
            => wrapper.GetRelated(e => e.ReportId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<ReportVisibility> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<ReportVisibility> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<ReportVisibility> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<ReportVisibility> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<ReportVisibility> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<ReportVisibility> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);

    }
    public static class ResourceExt
    {
        /// <summary>
        /// Related attribute: businessunitid. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetBusinessUnit(this IEntityWrapperRelation<Resource> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.BusinessUnitId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<Resource> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: siteid. Lookup to entity: site.
        /// </summary>
        public static IEntityWrapper<Site> GetSite(this IEntityWrapperRelation<Resource> wrapper, IColumnSet<Site> columnSet)
            => wrapper.GetRelated(e => e.SiteId, columnSet);

    }
    public static class ResourceGroupExt
    {
        /// <summary>
        /// Related attribute: businessunitid. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetBusinessUnit(this IEntityWrapperRelation<ResourceGroup> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.BusinessUnitId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<ResourceGroup> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class ResourceSpecExt
    {
        /// <summary>
        /// Related attribute: businessunitid. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetBusinessUnit(this IEntityWrapperRelation<ResourceSpec> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.BusinessUnitId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<ResourceSpec> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<ResourceSpec> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<ResourceSpec> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<ResourceSpec> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<ResourceSpec> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);

    }
    public static class RibbonCommandExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<RibbonCommand> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: ribboncustomizationid. Lookup to entity: ribboncustomization.
        /// </summary>
        public static IEntityWrapper<RibbonCustomization> GetRibbonCustomizationId(this IEntityWrapperRelation<RibbonCommand> wrapper, IColumnSet<RibbonCustomization> columnSet)
            => wrapper.GetRelated(e => e.RibbonCustomizationId, columnSet);

    }
    public static class RibbonContextGroupExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<RibbonContextGroup> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: ribboncustomizationid. Lookup to entity: ribboncustomization.
        /// </summary>
        public static IEntityWrapper<RibbonCustomization> GetRibbonCustomizationId(this IEntityWrapperRelation<RibbonContextGroup> wrapper, IColumnSet<RibbonCustomization> columnSet)
            => wrapper.GetRelated(e => e.RibbonCustomizationId, columnSet);

    }
    public static class RibbonCustomizationExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<RibbonCustomization> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class RibbonDiffExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<RibbonDiff> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: ribboncustomizationid. Lookup to entity: ribboncustomization.
        /// </summary>
        public static IEntityWrapper<RibbonCustomization> GetRibbonCustomizationId(this IEntityWrapperRelation<RibbonDiff> wrapper, IColumnSet<RibbonCustomization> columnSet)
            => wrapper.GetRelated(e => e.RibbonCustomizationId, columnSet);

    }
    public static class RibbonRuleExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<RibbonRule> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: ribboncustomizationid. Lookup to entity: ribboncustomization.
        /// </summary>
        public static IEntityWrapper<RibbonCustomization> GetRibbonCustomizationId(this IEntityWrapperRelation<RibbonRule> wrapper, IColumnSet<RibbonCustomization> columnSet)
            => wrapper.GetRelated(e => e.RibbonCustomizationId, columnSet);

    }
    public static class RibbonTabToCommandMapExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<RibbonTabToCommandMap> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: ribbondiffid. Lookup to entity: ribbondiff.
        /// </summary>
        public static IEntityWrapper<RibbonDiff> GetRibbonDiffId(this IEntityWrapperRelation<RibbonTabToCommandMap> wrapper, IColumnSet<RibbonDiff> columnSet)
            => wrapper.GetRelated(e => e.RibbonDiffId, columnSet);

    }
    public static class RoleExt
    {
        /// <summary>
        /// Related attribute: businessunitid. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetBusinessUnit(this IEntityWrapperRelation<Role> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.BusinessUnitId, columnSet);
        /// <summary>
        /// Related attribute: parentroleid. Lookup to entity: role.
        /// </summary>
        public static IEntityWrapper<Role> GetParentRole(this IEntityWrapperRelation<Role> wrapper, IColumnSet<Role> columnSet)
            => wrapper.GetRelated(e => e.ParentRoleId, columnSet);
        /// <summary>
        /// Related attribute: parentrootroleid. Lookup to entity: role.
        /// </summary>
        public static IEntityWrapper<Role> GetParentRootRole(this IEntityWrapperRelation<Role> wrapper, IColumnSet<Role> columnSet)
            => wrapper.GetRelated(e => e.ParentRootRoleId, columnSet);
        /// <summary>
        /// Related attribute: roletemplateid. Lookup to entity: roletemplate.
        /// </summary>
        public static IEntityWrapper<RoleTemplate> GetRoleTemplate(this IEntityWrapperRelation<Role> wrapper, IColumnSet<RoleTemplate> columnSet)
            => wrapper.GetRelated(e => e.RoleTemplateId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<Role> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByImpersonator(this IEntityWrapperRelation<Role> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<Role> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<Role> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);

    }
    public static class RollupFieldExt
    {
        /// <summary>
        /// Related attribute: metricid. Lookup to entity: metric.
        /// </summary>
        public static IEntityWrapper<Metric> GetGoalMetric(this IEntityWrapperRelation<RollupField> wrapper, IColumnSet<Metric> columnSet)
            => wrapper.GetRelated(e => e.MetricId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<RollupField> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<RollupField> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<RollupField> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<RollupField> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);

    }
    public static class RollupJobExt
    {
        /// <summary>
        /// Related attribute: rolluppropertiesid. Lookup to entity: rollupproperties.
        /// </summary>
        public static IEntityWrapper<RollupProperties> GetRollupPropertiesId(this IEntityWrapperRelation<RollupJob> wrapper, IColumnSet<RollupProperties> columnSet)
            => wrapper.GetRelated(e => e.RollupPropertiesId, columnSet);

    }
    public static class RoutingRuleExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<RoutingRule> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<RoutingRule> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);
        /// <summary>
        /// Related attribute: workflowid. Lookup to entity: workflow.
        /// </summary>
        public static IEntityWrapper<Workflow> GetWorkflow(this IEntityWrapperRelation<RoutingRule> wrapper, IColumnSet<Workflow> columnSet)
            => wrapper.GetRelated(e => e.WorkflowId, columnSet);

    }
    public static class RoutingRuleItemExt
    {
        /// <summary>
        /// Related attribute: owningbusinessunit. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetOwningBusinessUnit(this IEntityWrapperRelation<RoutingRuleItem> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.OwningBusinessUnit, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<RoutingRuleItem> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: routedqueueid. Lookup to entity: queue.
        /// </summary>
        public static IEntityWrapper<Queue> GetAddToQueue(this IEntityWrapperRelation<RoutingRuleItem> wrapper, IColumnSet<Queue> columnSet)
            => wrapper.GetRelated(e => e.RoutedQueueId, columnSet);
        /// <summary>
        /// Related attribute: routingruleid. Lookup to entity: routingrule.
        /// </summary>
        public static IEntityWrapper<RoutingRule> GetroutedRule(this IEntityWrapperRelation<RoutingRuleItem> wrapper, IColumnSet<RoutingRule> columnSet)
            => wrapper.GetRelated(e => e.RoutingRuleId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: assignobjectid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetAssignToUserTeam(this IEntityWrapperRelation<RoutingRuleItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.AssignObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: assignobjectid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetAssignToUserTeam(this IEntityWrapperRelation<RoutingRuleItem> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.AssignObjectId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<RoutingRuleItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<RoutingRuleItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<RoutingRuleItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<RoutingRuleItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<RoutingRuleItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<RoutingRuleItem> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Related attribute: owninguser. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwningUser(this IEntityWrapperRelation<RoutingRuleItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwningUser, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<RoutingRuleItem> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class SalesLiteratureExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<SalesLiterature> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: subjectid. Lookup to entity: subject.
        /// </summary>
        public static IEntityWrapper<Subject> GetSubject(this IEntityWrapperRelation<SalesLiterature> wrapper, IColumnSet<Subject> columnSet)
            => wrapper.GetRelated(e => e.SubjectId, columnSet);
        /// <summary>
        /// Related attribute: employeecontactid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetEmployeeContact(this IEntityWrapperRelation<SalesLiterature> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.EmployeeContactId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<SalesLiterature> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class SalesLiteratureItemExt
    {
        /// <summary>
        /// Related attribute: salesliteratureid. Lookup to entity: salesliterature.
        /// </summary>
        public static IEntityWrapper<SalesLiterature> GetSalesLiterature(this IEntityWrapperRelation<SalesLiteratureItem> wrapper, IColumnSet<SalesLiterature> columnSet)
            => wrapper.GetRelated(e => e.SalesLiteratureId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<SalesLiteratureItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<SalesLiteratureItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<SalesLiteratureItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<SalesLiteratureItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);

    }
    public static class SalesOrderExt
    {
        /// <summary>
        /// Related attribute: accountid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetAccount(this IEntityWrapperRelation<SalesOrder> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.AccountId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: customerid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetCustomer(this IEntityWrapperRelation<SalesOrder> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.CustomerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: customerid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetCustomer(this IEntityWrapperRelation<SalesOrder> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.CustomerId, columnSet);
        /// <summary>
        /// Related attribute: campaignid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetSourceCampaign(this IEntityWrapperRelation<SalesOrder> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.CampaignId, columnSet);
        /// <summary>
        /// Related attribute: contactid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetContact(this IEntityWrapperRelation<SalesOrder> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.ContactId, columnSet);
        /// <summary>
        /// Related attribute: opportunityid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetOpportunity(this IEntityWrapperRelation<SalesOrder> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.OpportunityId, columnSet);
        /// <summary>
        /// Related attribute: pricelevelid. Lookup to entity: pricelevel.
        /// </summary>
        public static IEntityWrapper<PriceLevel> GetPriceList(this IEntityWrapperRelation<SalesOrder> wrapper, IColumnSet<PriceLevel> columnSet)
            => wrapper.GetRelated(e => e.PriceLevelId, columnSet);
        /// <summary>
        /// Related attribute: quoteid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetQuote(this IEntityWrapperRelation<SalesOrder> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.QuoteId, columnSet);
        /// <summary>
        /// Related attribute: slaid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetSLA(this IEntityWrapperRelation<SalesOrder> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAId, columnSet);
        /// <summary>
        /// Related attribute: slainvokedid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetLastSLAApplied(this IEntityWrapperRelation<SalesOrder> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAInvokedId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<SalesOrder> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class SalesOrderDetailExt
    {
        /// <summary>
        /// Related attribute: productid. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetExistingProduct(this IEntityWrapperRelation<SalesOrderDetail> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.ProductId, columnSet);
        /// <summary>
        /// Related attribute: salesorderid. Lookup to entity: salesorder.
        /// </summary>
        public static IEntityWrapper<SalesOrder> GetOrder(this IEntityWrapperRelation<SalesOrderDetail> wrapper, IColumnSet<SalesOrder> columnSet)
            => wrapper.GetRelated(e => e.SalesOrderId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<SalesOrderDetail> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<SalesOrderDetail> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<SalesOrderDetail> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<SalesOrderDetail> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<SalesOrderDetail> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<SalesOrderDetail> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Related attribute: salesrepid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetSalesperson(this IEntityWrapperRelation<SalesOrderDetail> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.SalesRepId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<SalesOrderDetail> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);
        /// <summary>
        /// Related attribute: uomid. Lookup to entity: uom.
        /// </summary>
        public static IEntityWrapper<UoM> GetUnit(this IEntityWrapperRelation<SalesOrderDetail> wrapper, IColumnSet<UoM> columnSet)
            => wrapper.GetRelated(e => e.UoMId, columnSet);

    }
    public static class SalesProcessInstanceExt
    {

    }
    public static class SavedOrgInsightsConfigurationExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<SavedOrgInsightsConfiguration> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class SavedQueryExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<SavedQuery> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class SavedQueryVisualizationExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<SavedQueryVisualization> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: webresourceid. Lookup to entity: webresource.
        /// </summary>
        public static IEntityWrapper<WebResource> GetWebResource(this IEntityWrapperRelation<SavedQueryVisualization> wrapper, IColumnSet<WebResource> columnSet)
            => wrapper.GetRelated(e => e.WebResourceId, columnSet);

    }
    public static class SdkMessageExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<SdkMessage> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class SdkMessageFilterExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<SdkMessageFilter> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: sdkmessageid. Lookup to entity: sdkmessage.
        /// </summary>
        public static IEntityWrapper<SdkMessage> GetSDKMessageID(this IEntityWrapperRelation<SdkMessageFilter> wrapper, IColumnSet<SdkMessage> columnSet)
            => wrapper.GetRelated(e => e.SdkMessageId, columnSet);

    }
    public static class SdkMessagePairExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<SdkMessagePair> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: sdkmessageid. Lookup to entity: sdkmessage.
        /// </summary>
        public static IEntityWrapper<SdkMessage> GetSdkMessageId(this IEntityWrapperRelation<SdkMessagePair> wrapper, IColumnSet<SdkMessage> columnSet)
            => wrapper.GetRelated(e => e.SdkMessageId, columnSet);

    }
    public static class SdkMessageProcessingStepExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<SdkMessageProcessingStep> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: eventhandler. Lookup to entity: plugintype.
        /// </summary>
        public static IEntityWrapper<PluginType> GetEventHandler(this IEntityWrapperRelation<SdkMessageProcessingStep> wrapper, IColumnSet<PluginType> columnSet)
            => wrapper.GetRelated(e => e.EventHandler, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: eventhandler. Lookup to entity: serviceendpoint.
        /// </summary>
        public static IEntityWrapper<ServiceEndpoint> GetEventHandler(this IEntityWrapperRelation<SdkMessageProcessingStep> wrapper, IColumnSet<ServiceEndpoint> columnSet)
            => wrapper.GetRelated(e => e.EventHandler, columnSet);
        /// <summary>
        /// Related attribute: sdkmessageid. Lookup to entity: sdkmessage.
        /// </summary>
        public static IEntityWrapper<SdkMessage> GetSDKMessage(this IEntityWrapperRelation<SdkMessageProcessingStep> wrapper, IColumnSet<SdkMessage> columnSet)
            => wrapper.GetRelated(e => e.SdkMessageId, columnSet);
        /// <summary>
        /// Related attribute: plugintypeid. Lookup to entity: sdkmessagefilter.
        /// </summary>
        public static IEntityWrapper<SdkMessageFilter> GetplugInType(this IEntityWrapperRelation<SdkMessageProcessingStep> wrapper, IColumnSet<SdkMessageFilter> columnSet)
            => wrapper.GetRelated(e => e.PluginTypeId, columnSet);
        /// <summary>
        /// Related attribute: sdkmessagefilterid. Lookup to entity: sdkmessagefilter.
        /// </summary>
        public static IEntityWrapper<SdkMessageFilter> GetSdkMessageFilter(this IEntityWrapperRelation<SdkMessageProcessingStep> wrapper, IColumnSet<SdkMessageFilter> columnSet)
            => wrapper.GetRelated(e => e.SdkMessageFilterId, columnSet);
        /// <summary>
        /// Related attribute: sdkmessageprocessingstepsecureconfigid. Lookup to entity: sdkmessageprocessingstepsecureconfig.
        /// </summary>
        public static IEntityWrapper<SdkMessageProcessingStepSecureConfig> GetSDKMessageProcessingStepSecureConfiguration(this IEntityWrapperRelation<SdkMessageProcessingStep> wrapper, IColumnSet<SdkMessageProcessingStepSecureConfig> columnSet)
            => wrapper.GetRelated(e => e.SdkMessageProcessingStepSecureConfigId, columnSet);
        /// <summary>
        /// Related attribute: impersonatinguserid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetImpersonatingUser(this IEntityWrapperRelation<SdkMessageProcessingStep> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ImpersonatingUserId, columnSet);

    }
    public static class SdkMessageProcessingStepImageExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<SdkMessageProcessingStepImage> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: sdkmessageprocessingstepid. Lookup to entity: sdkmessageprocessingstep.
        /// </summary>
        public static IEntityWrapper<SdkMessageProcessingStep> GetSDKMessageProcessingStep(this IEntityWrapperRelation<SdkMessageProcessingStepImage> wrapper, IColumnSet<SdkMessageProcessingStep> columnSet)
            => wrapper.GetRelated(e => e.SdkMessageProcessingStepId, columnSet);

    }
    public static class SdkMessageProcessingStepSecureConfigExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<SdkMessageProcessingStepSecureConfig> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class SdkMessageRequestExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<SdkMessageRequest> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: sdkmessagepairid. Lookup to entity: sdkmessagepair.
        /// </summary>
        public static IEntityWrapper<SdkMessagePair> GetSdkMessagePairId(this IEntityWrapperRelation<SdkMessageRequest> wrapper, IColumnSet<SdkMessagePair> columnSet)
            => wrapper.GetRelated(e => e.SdkMessagePairId, columnSet);

    }
    public static class SdkMessageRequestFieldExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<SdkMessageRequestField> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: sdkmessagerequestid. Lookup to entity: sdkmessagerequest.
        /// </summary>
        public static IEntityWrapper<SdkMessageRequest> GetSdkMessageRequestId(this IEntityWrapperRelation<SdkMessageRequestField> wrapper, IColumnSet<SdkMessageRequest> columnSet)
            => wrapper.GetRelated(e => e.SdkMessageRequestId, columnSet);

    }
    public static class SdkMessageResponseExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<SdkMessageResponse> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: sdkmessagerequestid. Lookup to entity: sdkmessagerequest.
        /// </summary>
        public static IEntityWrapper<SdkMessageRequest> GetSdkMessageRequestId(this IEntityWrapperRelation<SdkMessageResponse> wrapper, IColumnSet<SdkMessageRequest> columnSet)
            => wrapper.GetRelated(e => e.SdkMessageRequestId, columnSet);

    }
    public static class SdkMessageResponseFieldExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<SdkMessageResponseField> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: sdkmessageresponseid. Lookup to entity: sdkmessageresponse.
        /// </summary>
        public static IEntityWrapper<SdkMessageResponse> GetSdkMessageResponseId(this IEntityWrapperRelation<SdkMessageResponseField> wrapper, IColumnSet<SdkMessageResponse> columnSet)
            => wrapper.GetRelated(e => e.SdkMessageResponseId, columnSet);

    }
    public static class SemiAnnualFiscalCalendarExt
    {
        /// <summary>
        /// Related attribute: businessunitid. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetBusinessUnitId(this IEntityWrapperRelation<SemiAnnualFiscalCalendar> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.BusinessUnitId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<SemiAnnualFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<SemiAnnualFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<SemiAnnualFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<SemiAnnualFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: salespersonid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetSalesPersonId(this IEntityWrapperRelation<SemiAnnualFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.SalesPersonId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<SemiAnnualFiscalCalendar> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class ServiceExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<Service> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: strategyid. Lookup to entity: plugintype.
        /// </summary>
        public static IEntityWrapper<PluginType> GetStrategy(this IEntityWrapperRelation<Service> wrapper, IColumnSet<PluginType> columnSet)
            => wrapper.GetRelated(e => e.StrategyId, columnSet);
        /// <summary>
        /// Related attribute: resourcespecid. Lookup to entity: resourcespec.
        /// </summary>
        public static IEntityWrapper<ResourceSpec> GetRequiredResources(this IEntityWrapperRelation<Service> wrapper, IColumnSet<ResourceSpec> columnSet)
            => wrapper.GetRelated(e => e.ResourceSpecId, columnSet);

    }
    public static class ServiceAppointmentExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetRegarding(this IEntityWrapperRelation<ServiceAppointment> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebooking.
        /// </summary>
        public static IEntityWrapper<BookableResourceBooking> GetRegarding(this IEntityWrapperRelation<ServiceAppointment> wrapper, IColumnSet<BookableResourceBooking> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebookingheader.
        /// </summary>
        public static IEntityWrapper<BookableResourceBookingHeader> GetRegarding(this IEntityWrapperRelation<ServiceAppointment> wrapper, IColumnSet<BookableResourceBookingHeader> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetRegarding(this IEntityWrapperRelation<ServiceAppointment> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetRegarding(this IEntityWrapperRelation<ServiceAppointment> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetRegarding(this IEntityWrapperRelation<ServiceAppointment> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlement.
        /// </summary>
        public static IEntityWrapper<Entitlement> GetRegarding(this IEntityWrapperRelation<ServiceAppointment> wrapper, IColumnSet<Entitlement> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlementtemplate.
        /// </summary>
        public static IEntityWrapper<EntitlementTemplate> GetRegarding(this IEntityWrapperRelation<ServiceAppointment> wrapper, IColumnSet<EntitlementTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetRegarding(this IEntityWrapperRelation<ServiceAppointment> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: invoice.
        /// </summary>
        public static IEntityWrapper<Invoice> GetRegarding(this IEntityWrapperRelation<ServiceAppointment> wrapper, IColumnSet<Invoice> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetRegarding(this IEntityWrapperRelation<ServiceAppointment> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgebaserecord.
        /// </summary>
        public static IEntityWrapper<KnowledgeBaseRecord> GetRegarding(this IEntityWrapperRelation<ServiceAppointment> wrapper, IColumnSet<KnowledgeBaseRecord> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetRegarding(this IEntityWrapperRelation<ServiceAppointment> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_postalbum.
        /// </summary>
        public static IEntityWrapper<msdyn_PostAlbum> GetRegarding(this IEntityWrapperRelation<ServiceAppointment> wrapper, IColumnSet<msdyn_PostAlbum> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetRegarding(this IEntityWrapperRelation<ServiceAppointment> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetRegarding(this IEntityWrapperRelation<ServiceAppointment> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesorder.
        /// </summary>
        public static IEntityWrapper<SalesOrder> GetRegarding(this IEntityWrapperRelation<ServiceAppointment> wrapper, IColumnSet<SalesOrder> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: serviceid. Lookup to entity: service.
        /// </summary>
        public static IEntityWrapper<Service> GetService(this IEntityWrapperRelation<ServiceAppointment> wrapper, IColumnSet<Service> columnSet)
            => wrapper.GetRelated(e => e.ServiceId, columnSet);
        /// <summary>
        /// Related attribute: siteid. Lookup to entity: site.
        /// </summary>
        public static IEntityWrapper<Site> GetSite(this IEntityWrapperRelation<ServiceAppointment> wrapper, IColumnSet<Site> columnSet)
            => wrapper.GetRelated(e => e.SiteId, columnSet);
        /// <summary>
        /// Related attribute: slaid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetSLA(this IEntityWrapperRelation<ServiceAppointment> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAId, columnSet);
        /// <summary>
        /// Related attribute: slainvokedid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetLastSLAApplied(this IEntityWrapperRelation<ServiceAppointment> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAInvokedId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<ServiceAppointment> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class ServiceEndpointExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<ServiceEndpoint> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class SharePointDataExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<SharePointData> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: location. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetLocation(this IEntityWrapperRelation<SharePointData> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.Location, columnSet);
        /// <summary>
        /// Related attribute: userid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetUserId(this IEntityWrapperRelation<SharePointData> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.UserId, columnSet);

    }
    public static class SharePointDocumentExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetRegarding(this IEntityWrapperRelation<SharePointDocument> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: kbarticle.
        /// </summary>
        public static IEntityWrapper<KbArticle> GetRegarding(this IEntityWrapperRelation<SharePointDocument> wrapper, IColumnSet<KbArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetRegarding(this IEntityWrapperRelation<SharePointDocument> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetRegarding(this IEntityWrapperRelation<SharePointDocument> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetRegarding(this IEntityWrapperRelation<SharePointDocument> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetRegarding(this IEntityWrapperRelation<SharePointDocument> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesliterature.
        /// </summary>
        public static IEntityWrapper<SalesLiterature> GetRegarding(this IEntityWrapperRelation<SharePointDocument> wrapper, IColumnSet<SalesLiterature> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: businessunitid. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetBusinessUnit(this IEntityWrapperRelation<SharePointDocument> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.BusinessUnitId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<SharePointDocument> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<SharePointDocument> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class SharePointDocumentLocationExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetRegarding(this IEntityWrapperRelation<SharePointDocumentLocation> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: kbarticle.
        /// </summary>
        public static IEntityWrapper<KbArticle> GetRegarding(this IEntityWrapperRelation<SharePointDocumentLocation> wrapper, IColumnSet<KbArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetRegarding(this IEntityWrapperRelation<SharePointDocumentLocation> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetRegarding(this IEntityWrapperRelation<SharePointDocumentLocation> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetRegarding(this IEntityWrapperRelation<SharePointDocumentLocation> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetRegarding(this IEntityWrapperRelation<SharePointDocumentLocation> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetRegarding(this IEntityWrapperRelation<SharePointDocumentLocation> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesliterature.
        /// </summary>
        public static IEntityWrapper<SalesLiterature> GetRegarding(this IEntityWrapperRelation<SharePointDocumentLocation> wrapper, IColumnSet<SalesLiterature> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: parentsiteorlocation. Lookup to entity: sharepointdocumentlocation.
        /// </summary>
        public static IEntityWrapper<SharePointDocumentLocation> GetParentSiteOrLocation(this IEntityWrapperRelation<SharePointDocumentLocation> wrapper, IColumnSet<SharePointDocumentLocation> columnSet)
            => wrapper.GetRelated(e => e.ParentSiteOrLocation, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: parentsiteorlocation. Lookup to entity: sharepointsite.
        /// </summary>
        public static IEntityWrapper<SharePointSite> GetParentSiteOrLocation(this IEntityWrapperRelation<SharePointDocumentLocation> wrapper, IColumnSet<SharePointSite> columnSet)
            => wrapper.GetRelated(e => e.ParentSiteOrLocation, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<SharePointDocumentLocation> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class SharePointSiteExt
    {
        /// <summary>
        /// Related attribute: parentsite. Lookup to entity: sharepointsite.
        /// </summary>
        public static IEntityWrapper<SharePointSite> GetParentSite(this IEntityWrapperRelation<SharePointSite> wrapper, IColumnSet<SharePointSite> columnSet)
            => wrapper.GetRelated(e => e.ParentSite, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<SharePointSite> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class SimilarityRuleExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<SimilarityRule> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<SimilarityRule> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class SiteMapExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<SiteMap> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class SLAExt
    {
        /// <summary>
        /// Related attribute: businesshoursid. Lookup to entity: calendar.
        /// </summary>
        public static IEntityWrapper<Calendar> GetBusinessHours(this IEntityWrapperRelation<SLA> wrapper, IColumnSet<Calendar> columnSet)
            => wrapper.GetRelated(e => e.BusinessHoursId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<SLA> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);
        /// <summary>
        /// Related attribute: workflowid. Lookup to entity: workflow.
        /// </summary>
        public static IEntityWrapper<Workflow> GetWorkflowID(this IEntityWrapperRelation<SLA> wrapper, IColumnSet<Workflow> columnSet)
            => wrapper.GetRelated(e => e.WorkflowId, columnSet);

    }
    public static class SLAItemExt
    {
        /// <summary>
        /// Related attribute: owningbusinessunit. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetOwningBusinessUnit(this IEntityWrapperRelation<SLAItem> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.OwningBusinessUnit, columnSet);
        /// <summary>
        /// Related attribute: slaid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetSLA(this IEntityWrapperRelation<SLAItem> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<SLAItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<SLAItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<SLAItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<SLAItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<SLAItem> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<SLAItem> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<SLAItem> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);
        /// <summary>
        /// Related attribute: workflowid. Lookup to entity: workflow.
        /// </summary>
        public static IEntityWrapper<Workflow> GetWorkflowID(this IEntityWrapperRelation<SLAItem> wrapper, IColumnSet<Workflow> columnSet)
            => wrapper.GetRelated(e => e.WorkflowId, columnSet);

    }
    public static class SLAKPIInstanceExt
    {
        /// <summary>
        /// Related attribute: regarding. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetRegarding(this IEntityWrapperRelation<SLAKPIInstance> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.Regarding, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<SLAKPIInstance> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class SocialActivityExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: postauthor. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetPostAuthor(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.PostAuthor, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: postauthor. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetPostAuthor(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.PostAuthor, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: postauthoraccount. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetPostAuthorAccount(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.PostAuthorAccount, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: postauthoraccount. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetPostAuthorAccount(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.PostAuthorAccount, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetRegarding(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: asyncoperation.
        /// </summary>
        public static IEntityWrapper<AsyncOperation> GetRegarding(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<AsyncOperation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebooking.
        /// </summary>
        public static IEntityWrapper<BookableResourceBooking> GetRegarding(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<BookableResourceBooking> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebookingheader.
        /// </summary>
        public static IEntityWrapper<BookableResourceBookingHeader> GetRegarding(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<BookableResourceBookingHeader> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bulkoperation.
        /// </summary>
        public static IEntityWrapper<BulkOperation> GetRegarding(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<BulkOperation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetRegarding(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetRegarding(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlement.
        /// </summary>
        public static IEntityWrapper<Entitlement> GetRegarding(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<Entitlement> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlementtemplate.
        /// </summary>
        public static IEntityWrapper<EntitlementTemplate> GetRegarding(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<EntitlementTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetRegarding(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: invoice.
        /// </summary>
        public static IEntityWrapper<Invoice> GetRegarding(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<Invoice> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetRegarding(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgebaserecord.
        /// </summary>
        public static IEntityWrapper<KnowledgeBaseRecord> GetRegarding(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<KnowledgeBaseRecord> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetRegarding(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_postalbum.
        /// </summary>
        public static IEntityWrapper<msdyn_PostAlbum> GetRegarding(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<msdyn_PostAlbum> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetRegarding(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetRegarding(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesorder.
        /// </summary>
        public static IEntityWrapper<SalesOrder> GetRegarding(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<SalesOrder> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: serviceid. Lookup to entity: service.
        /// </summary>
        public static IEntityWrapper<Service> GetService(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<Service> columnSet)
            => wrapper.GetRelated(e => e.ServiceId, columnSet);
        /// <summary>
        /// Related attribute: slaid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetSLA(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAId, columnSet);
        /// <summary>
        /// Related attribute: slainvokedid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetLastSLAApplied(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAInvokedId, columnSet);
        /// <summary>
        /// Related attribute: postfromprofileid. Lookup to entity: socialprofile.
        /// </summary>
        public static IEntityWrapper<SocialProfile> GetPostedBy(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<SocialProfile> columnSet)
            => wrapper.GetRelated(e => e.PostFromProfileId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<SocialActivity> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class SocialInsightsConfigurationExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<SocialInsightsConfiguration> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: formid. Lookup to entity: systemform.
        /// </summary>
        public static IEntityWrapper<SystemForm> GetAssociatedForm(this IEntityWrapperRelation<SocialInsightsConfiguration> wrapper, IColumnSet<SystemForm> columnSet)
            => wrapper.GetRelated(e => e.FormId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: formid. Lookup to entity: userform.
        /// </summary>
        public static IEntityWrapper<UserForm> GetAssociatedForm(this IEntityWrapperRelation<SocialInsightsConfiguration> wrapper, IColumnSet<UserForm> columnSet)
            => wrapper.GetRelated(e => e.FormId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<SocialInsightsConfiguration> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<SocialInsightsConfiguration> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<SocialInsightsConfiguration> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<SocialInsightsConfiguration> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);

    }
    public static class SocialProfileExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: customerid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetCustomer(this IEntityWrapperRelation<SocialProfile> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.CustomerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: customerid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetCustomer(this IEntityWrapperRelation<SocialProfile> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.CustomerId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<SocialProfile> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class SolutionExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<Solution> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: publisherid. Lookup to entity: publisher.
        /// </summary>
        public static IEntityWrapper<Publisher> GetPublisher(this IEntityWrapperRelation<Solution> wrapper, IColumnSet<Publisher> columnSet)
            => wrapper.GetRelated(e => e.PublisherId, columnSet);
        /// <summary>
        /// Related attribute: parentsolutionid. Lookup to entity: solution.
        /// </summary>
        public static IEntityWrapper<Solution> GetParentSolution(this IEntityWrapperRelation<Solution> wrapper, IColumnSet<Solution> columnSet)
            => wrapper.GetRelated(e => e.ParentSolutionId, columnSet);
        /// <summary>
        /// Related attribute: configurationpageid. Lookup to entity: webresource.
        /// </summary>
        public static IEntityWrapper<WebResource> GetConfigurationPage(this IEntityWrapperRelation<Solution> wrapper, IColumnSet<WebResource> columnSet)
            => wrapper.GetRelated(e => e.ConfigurationPageId, columnSet);

    }
    public static class SolutionComponentExt
    {
        /// <summary>
        /// Related attribute: solutionid. Lookup to entity: solution.
        /// </summary>
        public static IEntityWrapper<Solution> GetSolution(this IEntityWrapperRelation<SolutionComponent> wrapper, IColumnSet<Solution> columnSet)
            => wrapper.GetRelated(e => e.SolutionId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<SolutionComponent> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<SolutionComponent> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<SolutionComponent> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<SolutionComponent> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);

    }
    public static class SqlEncryptionAuditExt
    {
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<SqlEncryptionAudit> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);

    }
    public static class SubjectExt
    {
        /// <summary>
        /// Related attribute: createdbyexternalparty. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetCreatedByExternalParty(this IEntityWrapperRelation<Subject> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.CreatedByExternalParty, columnSet);
        /// <summary>
        /// Related attribute: modifiedbyexternalparty. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetModifiedByExternalParty(this IEntityWrapperRelation<Subject> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.ModifiedByExternalParty, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<Subject> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: parentsubject. Lookup to entity: subject.
        /// </summary>
        public static IEntityWrapper<Subject> GetParentSubject(this IEntityWrapperRelation<Subject> wrapper, IColumnSet<Subject> columnSet)
            => wrapper.GetRelated(e => e.ParentSubject, columnSet);

    }
    public static class SubscriptionSyncInfoExt
    {
        /// <summary>
        /// Related attribute: subscriptionid. Lookup to entity: subscription.
        /// </summary>
        public static IEntityWrapper<Subscription> GetSubscriptionId(this IEntityWrapperRelation<SubscriptionSyncInfo> wrapper, IColumnSet<Subscription> columnSet)
            => wrapper.GetRelated(e => e.SubscriptionId, columnSet);

    }
    public static class SyncAttributeMappingExt
    {
        /// <summary>
        /// Related attribute: parentsyncattributemappingid. Lookup to entity: syncattributemapping.
        /// </summary>
        public static IEntityWrapper<SyncAttributeMapping> GetParentSyncAttributeMapping(this IEntityWrapperRelation<SyncAttributeMapping> wrapper, IColumnSet<SyncAttributeMapping> columnSet)
            => wrapper.GetRelated(e => e.ParentSyncAttributeMappingId, columnSet);
        /// <summary>
        /// Related attribute: syncattributemappingprofileid. Lookup to entity: syncattributemappingprofile.
        /// </summary>
        public static IEntityWrapper<SyncAttributeMappingProfile> GetProfile(this IEntityWrapperRelation<SyncAttributeMapping> wrapper, IColumnSet<SyncAttributeMappingProfile> columnSet)
            => wrapper.GetRelated(e => e.SyncAttributeMappingProfileId, columnSet);

    }
    public static class SyncAttributeMappingProfileExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<SyncAttributeMappingProfile> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class SyncErrorExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: activitymimeattachment.
        /// </summary>
        public static IEntityWrapper<ActivityMimeAttachment> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<ActivityMimeAttachment> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: activityparty.
        /// </summary>
        public static IEntityWrapper<ActivityParty> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<ActivityParty> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: annotation.
        /// </summary>
        public static IEntityWrapper<Annotation> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Annotation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: appointment.
        /// </summary>
        public static IEntityWrapper<Appointment> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Appointment> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: attachment.
        /// </summary>
        public static IEntityWrapper<Attachment> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Attachment> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresource.
        /// </summary>
        public static IEntityWrapper<BookableResource> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<BookableResource> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebooking.
        /// </summary>
        public static IEntityWrapper<BookableResourceBooking> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<BookableResourceBooking> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebookingheader.
        /// </summary>
        public static IEntityWrapper<BookableResourceBookingHeader> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<BookableResourceBookingHeader> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcecategory.
        /// </summary>
        public static IEntityWrapper<BookableResourceCategory> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<BookableResourceCategory> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcecategoryassn.
        /// </summary>
        public static IEntityWrapper<BookableResourceCategoryAssn> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<BookableResourceCategoryAssn> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcecharacteristic.
        /// </summary>
        public static IEntityWrapper<BookableResourceCharacteristic> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<BookableResourceCharacteristic> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcegroup.
        /// </summary>
        public static IEntityWrapper<BookableResourceGroup> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<BookableResourceGroup> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookingstatus.
        /// </summary>
        public static IEntityWrapper<BookingStatus> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<BookingStatus> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bulkoperation.
        /// </summary>
        public static IEntityWrapper<BulkOperation> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<BulkOperation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: businessdatalocalizedlabel.
        /// </summary>
        public static IEntityWrapper<BusinessDataLocalizedLabel> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<BusinessDataLocalizedLabel> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaignactivity.
        /// </summary>
        public static IEntityWrapper<CampaignActivity> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<CampaignActivity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaignresponse.
        /// </summary>
        public static IEntityWrapper<CampaignResponse> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<CampaignResponse> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: category.
        /// </summary>
        public static IEntityWrapper<Category> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Category> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: channelaccessprofile.
        /// </summary>
        public static IEntityWrapper<ChannelAccessProfile> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<ChannelAccessProfile> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: channelaccessprofilerule.
        /// </summary>
        public static IEntityWrapper<ChannelAccessProfileRule> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<ChannelAccessProfileRule> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: channelaccessprofileruleitem.
        /// </summary>
        public static IEntityWrapper<ChannelAccessProfileRuleItem> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<ChannelAccessProfileRuleItem> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: characteristic.
        /// </summary>
        public static IEntityWrapper<Characteristic> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Characteristic> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: competitor.
        /// </summary>
        public static IEntityWrapper<Competitor> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Competitor> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: competitoraddress.
        /// </summary>
        public static IEntityWrapper<CompetitorAddress> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<CompetitorAddress> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: connection.
        /// </summary>
        public static IEntityWrapper<Connection> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Connection> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: connectionrole.
        /// </summary>
        public static IEntityWrapper<ConnectionRole> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<ConnectionRole> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contractdetail.
        /// </summary>
        public static IEntityWrapper<ContractDetail> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<ContractDetail> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contracttemplate.
        /// </summary>
        public static IEntityWrapper<ContractTemplate> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<ContractTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: customeraddress.
        /// </summary>
        public static IEntityWrapper<CustomerAddress> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<CustomerAddress> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: customeropportunityrole.
        /// </summary>
        public static IEntityWrapper<CustomerOpportunityRole> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<CustomerOpportunityRole> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: discount.
        /// </summary>
        public static IEntityWrapper<Discount> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Discount> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: discounttype.
        /// </summary>
        public static IEntityWrapper<DiscountType> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<DiscountType> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: duplicaterule.
        /// </summary>
        public static IEntityWrapper<DuplicateRule> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<DuplicateRule> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: duplicaterulecondition.
        /// </summary>
        public static IEntityWrapper<DuplicateRuleCondition> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<DuplicateRuleCondition> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: email.
        /// </summary>
        public static IEntityWrapper<Email> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Email> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: emailserverprofile.
        /// </summary>
        public static IEntityWrapper<EmailServerProfile> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<EmailServerProfile> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlement.
        /// </summary>
        public static IEntityWrapper<Entitlement> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Entitlement> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlementtemplate.
        /// </summary>
        public static IEntityWrapper<EntitlementTemplate> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<EntitlementTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: equipment.
        /// </summary>
        public static IEntityWrapper<Equipment> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Equipment> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: expiredprocess.
        /// </summary>
        public static IEntityWrapper<ExpiredProcess> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<ExpiredProcess> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: externalpartyitem.
        /// </summary>
        public static IEntityWrapper<ExternalPartyItem> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<ExternalPartyItem> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: fax.
        /// </summary>
        public static IEntityWrapper<Fax> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Fax> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: feedback.
        /// </summary>
        public static IEntityWrapper<Feedback> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Feedback> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: fieldpermission.
        /// </summary>
        public static IEntityWrapper<FieldPermission> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<FieldPermission> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: fieldsecurityprofile.
        /// </summary>
        public static IEntityWrapper<FieldSecurityProfile> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<FieldSecurityProfile> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: goal.
        /// </summary>
        public static IEntityWrapper<Goal> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Goal> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: goalrollupquery.
        /// </summary>
        public static IEntityWrapper<GoalRollupQuery> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<GoalRollupQuery> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: importmap.
        /// </summary>
        public static IEntityWrapper<ImportMap> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<ImportMap> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: incidentresolution.
        /// </summary>
        public static IEntityWrapper<IncidentResolution> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<IncidentResolution> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: ins_salesorder.
        /// </summary>
        public static IEntityWrapper<ins_salesorder> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<ins_salesorder> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: ins_salesorderline.
        /// </summary>
        public static IEntityWrapper<ins_salesorderline> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<ins_salesorderline> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: internaladdress.
        /// </summary>
        public static IEntityWrapper<InternalAddress> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<InternalAddress> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: invoice.
        /// </summary>
        public static IEntityWrapper<Invoice> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Invoice> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: invoicedetail.
        /// </summary>
        public static IEntityWrapper<InvoiceDetail> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<InvoiceDetail> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: kbarticle.
        /// </summary>
        public static IEntityWrapper<KbArticle> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<KbArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: kbarticletemplate.
        /// </summary>
        public static IEntityWrapper<KbArticleTemplate> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<KbArticleTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgearticleincident.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticleIncident> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<KnowledgeArticleIncident> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgearticleviews.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticleViews> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<KnowledgeArticleViews> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgebaserecord.
        /// </summary>
        public static IEntityWrapper<KnowledgeBaseRecord> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<KnowledgeBaseRecord> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: leadaddress.
        /// </summary>
        public static IEntityWrapper<LeadAddress> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<LeadAddress> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: leadtoopportunitysalesprocess.
        /// </summary>
        public static IEntityWrapper<LeadToOpportunitySalesProcess> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<LeadToOpportunitySalesProcess> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: letter.
        /// </summary>
        public static IEntityWrapper<Letter> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Letter> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: list.
        /// </summary>
        public static IEntityWrapper<List> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<List> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: mailbox.
        /// </summary>
        public static IEntityWrapper<Mailbox> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Mailbox> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: mailmergetemplate.
        /// </summary>
        public static IEntityWrapper<MailMergeTemplate> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<MailMergeTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: metric.
        /// </summary>
        public static IEntityWrapper<Metric> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Metric> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_postalbum.
        /// </summary>
        public static IEntityWrapper<msdyn_PostAlbum> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<msdyn_PostAlbum> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_postconfig.
        /// </summary>
        public static IEntityWrapper<msdyn_PostConfig> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<msdyn_PostConfig> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_postruleconfig.
        /// </summary>
        public static IEntityWrapper<msdyn_PostRuleConfig> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<msdyn_PostRuleConfig> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_wallsavedquery.
        /// </summary>
        public static IEntityWrapper<msdyn_wallsavedquery> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<msdyn_wallsavedquery> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_wallsavedqueryusersettings.
        /// </summary>
        public static IEntityWrapper<msdyn_wallsavedqueryusersettings> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<msdyn_wallsavedqueryusersettings> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: newprocess.
        /// </summary>
        public static IEntityWrapper<NewProcess> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<NewProcess> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunityclose.
        /// </summary>
        public static IEntityWrapper<OpportunityClose> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<OpportunityClose> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunityproduct.
        /// </summary>
        public static IEntityWrapper<OpportunityProduct> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<OpportunityProduct> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunitysalesprocess.
        /// </summary>
        public static IEntityWrapper<OpportunitySalesProcess> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<OpportunitySalesProcess> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: orderclose.
        /// </summary>
        public static IEntityWrapper<OrderClose> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<OrderClose> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: phonecall.
        /// </summary>
        public static IEntityWrapper<PhoneCall> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<PhoneCall> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: phonetocaseprocess.
        /// </summary>
        public static IEntityWrapper<PhoneToCaseProcess> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<PhoneToCaseProcess> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: position.
        /// </summary>
        public static IEntityWrapper<Position> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Position> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: postfollow.
        /// </summary>
        public static IEntityWrapper<PostFollow> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<PostFollow> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: pricelevel.
        /// </summary>
        public static IEntityWrapper<PriceLevel> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<PriceLevel> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: processsession.
        /// </summary>
        public static IEntityWrapper<ProcessSession> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<ProcessSession> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: processstage.
        /// </summary>
        public static IEntityWrapper<ProcessStage> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<ProcessStage> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: processtrigger.
        /// </summary>
        public static IEntityWrapper<ProcessTrigger> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<ProcessTrigger> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: productassociation.
        /// </summary>
        public static IEntityWrapper<ProductAssociation> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<ProductAssociation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: productpricelevel.
        /// </summary>
        public static IEntityWrapper<ProductPriceLevel> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<ProductPriceLevel> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: productsubstitute.
        /// </summary>
        public static IEntityWrapper<ProductSubstitute> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<ProductSubstitute> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: publisher.
        /// </summary>
        public static IEntityWrapper<Publisher> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Publisher> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: queue.
        /// </summary>
        public static IEntityWrapper<Queue> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Queue> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: queueitem.
        /// </summary>
        public static IEntityWrapper<QueueItem> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<QueueItem> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quoteclose.
        /// </summary>
        public static IEntityWrapper<QuoteClose> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<QuoteClose> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quotedetail.
        /// </summary>
        public static IEntityWrapper<QuoteDetail> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<QuoteDetail> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: ratingmodel.
        /// </summary>
        public static IEntityWrapper<RatingModel> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<RatingModel> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: ratingvalue.
        /// </summary>
        public static IEntityWrapper<RatingValue> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<RatingValue> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: recurringappointmentmaster.
        /// </summary>
        public static IEntityWrapper<RecurringAppointmentMaster> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<RecurringAppointmentMaster> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: report.
        /// </summary>
        public static IEntityWrapper<Report> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Report> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: reportcategory.
        /// </summary>
        public static IEntityWrapper<ReportCategory> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<ReportCategory> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: resource.
        /// </summary>
        public static IEntityWrapper<Resource> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Resource> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: resourcegroup.
        /// </summary>
        public static IEntityWrapper<ResourceGroup> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<ResourceGroup> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: resourcegroupexpansion.
        /// </summary>
        public static IEntityWrapper<ResourceGroupExpansion> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<ResourceGroupExpansion> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: role.
        /// </summary>
        public static IEntityWrapper<Role> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Role> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: rollupfield.
        /// </summary>
        public static IEntityWrapper<RollupField> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<RollupField> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesliterature.
        /// </summary>
        public static IEntityWrapper<SalesLiterature> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<SalesLiterature> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesorder.
        /// </summary>
        public static IEntityWrapper<SalesOrder> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<SalesOrder> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesorderdetail.
        /// </summary>
        public static IEntityWrapper<SalesOrderDetail> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<SalesOrderDetail> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: savedquery.
        /// </summary>
        public static IEntityWrapper<SavedQuery> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<SavedQuery> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: savedqueryvisualization.
        /// </summary>
        public static IEntityWrapper<SavedQueryVisualization> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<SavedQueryVisualization> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: service.
        /// </summary>
        public static IEntityWrapper<Service> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Service> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: serviceappointment.
        /// </summary>
        public static IEntityWrapper<ServiceAppointment> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<ServiceAppointment> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: sharepointdocumentlocation.
        /// </summary>
        public static IEntityWrapper<SharePointDocumentLocation> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<SharePointDocumentLocation> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: sharepointsite.
        /// </summary>
        public static IEntityWrapper<SharePointSite> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<SharePointSite> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: site.
        /// </summary>
        public static IEntityWrapper<Site> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Site> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: slaitem.
        /// </summary>
        public static IEntityWrapper<SLAItem> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<SLAItem> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: slakpiinstance.
        /// </summary>
        public static IEntityWrapper<SLAKPIInstance> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<SLAKPIInstance> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: socialactivity.
        /// </summary>
        public static IEntityWrapper<SocialActivity> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<SocialActivity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: socialprofile.
        /// </summary>
        public static IEntityWrapper<SocialProfile> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<SocialProfile> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: solution.
        /// </summary>
        public static IEntityWrapper<Solution> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Solution> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: subject.
        /// </summary>
        public static IEntityWrapper<Subject> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Subject> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: syncerror.
        /// </summary>
        public static IEntityWrapper<SyncError> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<SyncError> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: task.
        /// </summary>
        public static IEntityWrapper<Task> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Task> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: teamtemplate.
        /// </summary>
        public static IEntityWrapper<TeamTemplate> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<TeamTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: template.
        /// </summary>
        public static IEntityWrapper<Template> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Template> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: territory.
        /// </summary>
        public static IEntityWrapper<Territory> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Territory> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: translationprocess.
        /// </summary>
        public static IEntityWrapper<TranslationProcess> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<TranslationProcess> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: uom.
        /// </summary>
        public static IEntityWrapper<UoM> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<UoM> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: uomschedule.
        /// </summary>
        public static IEntityWrapper<UoMSchedule> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<UoMSchedule> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: userquery.
        /// </summary>
        public static IEntityWrapper<UserQuery> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<UserQuery> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: userqueryvisualization.
        /// </summary>
        public static IEntityWrapper<UserQueryVisualization> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<UserQueryVisualization> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: workflow.
        /// </summary>
        public static IEntityWrapper<Workflow> GetRecord(this IEntityWrapperRelation<SyncError> wrapper, IColumnSet<Workflow> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);

    }
    public static class SystemApplicationMetadataExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<SystemApplicationMetadata> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<SystemApplicationMetadata> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<SystemApplicationMetadata> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<SystemApplicationMetadata> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<SystemApplicationMetadata> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);

    }
    public static class SystemFormExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<SystemForm> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: ancestorformid. Lookup to entity: systemform.
        /// </summary>
        public static IEntityWrapper<SystemForm> GetParentForm(this IEntityWrapperRelation<SystemForm> wrapper, IColumnSet<SystemForm> columnSet)
            => wrapper.GetRelated(e => e.AncestorFormId, columnSet);

    }
    public static class SystemUserExt
    {
        /// <summary>
        /// Related attribute: businessunitid. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetBusinessUnit(this IEntityWrapperRelation<SystemUser> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.BusinessUnitId, columnSet);
        /// <summary>
        /// Related attribute: calendarid. Lookup to entity: calendar.
        /// </summary>
        public static IEntityWrapper<Calendar> GetCalendar(this IEntityWrapperRelation<SystemUser> wrapper, IColumnSet<Calendar> columnSet)
            => wrapper.GetRelated(e => e.CalendarId, columnSet);
        /// <summary>
        /// Related attribute: defaultmailbox. Lookup to entity: mailbox.
        /// </summary>
        public static IEntityWrapper<Mailbox> GetMailbox(this IEntityWrapperRelation<SystemUser> wrapper, IColumnSet<Mailbox> columnSet)
            => wrapper.GetRelated(e => e.DefaultMailbox, columnSet);
        /// <summary>
        /// Related attribute: mobileofflineprofileid. Lookup to entity: mobileofflineprofile.
        /// </summary>
        public static IEntityWrapper<MobileOfflineProfile> GetMobileOfflineProfile(this IEntityWrapperRelation<SystemUser> wrapper, IColumnSet<MobileOfflineProfile> columnSet)
            => wrapper.GetRelated(e => e.MobileOfflineProfileId, columnSet);
        /// <summary>
        /// Related attribute: positionid. Lookup to entity: position.
        /// </summary>
        public static IEntityWrapper<Position> GetPosition(this IEntityWrapperRelation<SystemUser> wrapper, IColumnSet<Position> columnSet)
            => wrapper.GetRelated(e => e.PositionId, columnSet);
        /// <summary>
        /// Related attribute: queueid. Lookup to entity: queue.
        /// </summary>
        public static IEntityWrapper<Queue> GetDefaultQueue(this IEntityWrapperRelation<SystemUser> wrapper, IColumnSet<Queue> columnSet)
            => wrapper.GetRelated(e => e.QueueId, columnSet);
        /// <summary>
        /// Related attribute: siteid. Lookup to entity: site.
        /// </summary>
        public static IEntityWrapper<Site> GetSite(this IEntityWrapperRelation<SystemUser> wrapper, IColumnSet<Site> columnSet)
            => wrapper.GetRelated(e => e.SiteId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<SystemUser> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<SystemUser> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<SystemUser> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<SystemUser> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: parentsystemuserid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetManager(this IEntityWrapperRelation<SystemUser> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ParentSystemUserId, columnSet);
        /// <summary>
        /// Related attribute: territoryid. Lookup to entity: territory.
        /// </summary>
        public static IEntityWrapper<Territory> GetTerritory(this IEntityWrapperRelation<SystemUser> wrapper, IColumnSet<Territory> columnSet)
            => wrapper.GetRelated(e => e.TerritoryId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<SystemUser> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class TaskExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetRegarding(this IEntityWrapperRelation<Task> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebooking.
        /// </summary>
        public static IEntityWrapper<BookableResourceBooking> GetRegarding(this IEntityWrapperRelation<Task> wrapper, IColumnSet<BookableResourceBooking> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: bookableresourcebookingheader.
        /// </summary>
        public static IEntityWrapper<BookableResourceBookingHeader> GetRegarding(this IEntityWrapperRelation<Task> wrapper, IColumnSet<BookableResourceBookingHeader> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetRegarding(this IEntityWrapperRelation<Task> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: campaignactivity.
        /// </summary>
        public static IEntityWrapper<CampaignActivity> GetRegarding(this IEntityWrapperRelation<Task> wrapper, IColumnSet<CampaignActivity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetRegarding(this IEntityWrapperRelation<Task> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetRegarding(this IEntityWrapperRelation<Task> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlement.
        /// </summary>
        public static IEntityWrapper<Entitlement> GetRegarding(this IEntityWrapperRelation<Task> wrapper, IColumnSet<Entitlement> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: entitlementtemplate.
        /// </summary>
        public static IEntityWrapper<EntitlementTemplate> GetRegarding(this IEntityWrapperRelation<Task> wrapper, IColumnSet<EntitlementTemplate> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetRegarding(this IEntityWrapperRelation<Task> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: invoice.
        /// </summary>
        public static IEntityWrapper<Invoice> GetRegarding(this IEntityWrapperRelation<Task> wrapper, IColumnSet<Invoice> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetRegarding(this IEntityWrapperRelation<Task> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgebaserecord.
        /// </summary>
        public static IEntityWrapper<KnowledgeBaseRecord> GetRegarding(this IEntityWrapperRelation<Task> wrapper, IColumnSet<KnowledgeBaseRecord> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetRegarding(this IEntityWrapperRelation<Task> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: msdyn_postalbum.
        /// </summary>
        public static IEntityWrapper<msdyn_PostAlbum> GetRegarding(this IEntityWrapperRelation<Task> wrapper, IColumnSet<msdyn_PostAlbum> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetRegarding(this IEntityWrapperRelation<Task> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetRegarding(this IEntityWrapperRelation<Task> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: salesorder.
        /// </summary>
        public static IEntityWrapper<SalesOrder> GetRegarding(this IEntityWrapperRelation<Task> wrapper, IColumnSet<SalesOrder> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: serviceid. Lookup to entity: service.
        /// </summary>
        public static IEntityWrapper<Service> GetService(this IEntityWrapperRelation<Task> wrapper, IColumnSet<Service> columnSet)
            => wrapper.GetRelated(e => e.ServiceId, columnSet);
        /// <summary>
        /// Related attribute: slaid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetSLA(this IEntityWrapperRelation<Task> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAId, columnSet);
        /// <summary>
        /// Related attribute: slainvokedid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetLastSLAApplied(this IEntityWrapperRelation<Task> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.SLAInvokedId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Task> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class TeamExt
    {
        /// <summary>
        /// Related attribute: businessunitid. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetBusinessUnit(this IEntityWrapperRelation<Team> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.BusinessUnitId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetRegardingObjectId(this IEntityWrapperRelation<Team> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetRegardingObjectId(this IEntityWrapperRelation<Team> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: queueid. Lookup to entity: queue.
        /// </summary>
        public static IEntityWrapper<Queue> GetDefaultQueue(this IEntityWrapperRelation<Team> wrapper, IColumnSet<Queue> columnSet)
            => wrapper.GetRelated(e => e.QueueId, columnSet);
        /// <summary>
        /// Related attribute: administratorid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetAdministrator(this IEntityWrapperRelation<Team> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.AdministratorId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<Team> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<Team> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<Team> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<Team> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: teamtemplateid. Lookup to entity: teamtemplate.
        /// </summary>
        public static IEntityWrapper<TeamTemplate> GetTeamTemplateIdentifier(this IEntityWrapperRelation<Team> wrapper, IColumnSet<TeamTemplate> columnSet)
            => wrapper.GetRelated(e => e.TeamTemplateId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Team> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class TeamTemplateExt
    {
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<TeamTemplate> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<TeamTemplate> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<TeamTemplate> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<TeamTemplate> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);

    }
    public static class TerritoryExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<Territory> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: managerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetManager(this IEntityWrapperRelation<Territory> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ManagerId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Territory> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class TextAnalyticsEntityMappingExt
    {
        /// <summary>
        /// Related attribute: advancedsimilarityruleid. Lookup to entity: advancedsimilarityrule.
        /// </summary>
        public static IEntityWrapper<AdvancedSimilarityRule> GetAdvancedSimilarityRuleId(this IEntityWrapperRelation<TextAnalyticsEntityMapping> wrapper, IColumnSet<AdvancedSimilarityRule> columnSet)
            => wrapper.GetRelated(e => e.AdvancedSimilarityRuleId, columnSet);
        /// <summary>
        /// Related attribute: knowledgesearchmodelid. Lookup to entity: knowledgesearchmodel.
        /// </summary>
        public static IEntityWrapper<KnowledgeSearchModel> GetKnowledgeSearchModelId(this IEntityWrapperRelation<TextAnalyticsEntityMapping> wrapper, IColumnSet<KnowledgeSearchModel> columnSet)
            => wrapper.GetRelated(e => e.KnowledgeSearchModelId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<TextAnalyticsEntityMapping> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: similarityruleid. Lookup to entity: similarityrule.
        /// </summary>
        public static IEntityWrapper<SimilarityRule> GetSimilarityRuleId(this IEntityWrapperRelation<TextAnalyticsEntityMapping> wrapper, IColumnSet<SimilarityRule> columnSet)
            => wrapper.GetRelated(e => e.SimilarityRuleId, columnSet);
        /// <summary>
        /// Related attribute: topicmodelconfigurationid. Lookup to entity: topicmodelconfiguration.
        /// </summary>
        public static IEntityWrapper<TopicModelConfiguration> GetTopicModelConfigurationId(this IEntityWrapperRelation<TextAnalyticsEntityMapping> wrapper, IColumnSet<TopicModelConfiguration> columnSet)
            => wrapper.GetRelated(e => e.TopicModelConfigurationId, columnSet);

    }
    public static class ThemeExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<Theme> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<Theme> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);
        /// <summary>
        /// Related attribute: logoid. Lookup to entity: webresource.
        /// </summary>
        public static IEntityWrapper<WebResource> GetLogo(this IEntityWrapperRelation<Theme> wrapper, IColumnSet<WebResource> columnSet)
            => wrapper.GetRelated(e => e.LogoId, columnSet);

    }
    public static class TimeZoneDefinitionExt
    {
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<TimeZoneDefinition> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<TimeZoneDefinition> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<TimeZoneDefinition> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<TimeZoneDefinition> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);

    }
    public static class TimeZoneLocalizedNameExt
    {
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<TimeZoneLocalizedName> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<TimeZoneLocalizedName> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<TimeZoneLocalizedName> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<TimeZoneLocalizedName> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: timezonedefinitionid. Lookup to entity: timezonedefinition.
        /// </summary>
        public static IEntityWrapper<TimeZoneDefinition> GetTimeZoneDefinition(this IEntityWrapperRelation<TimeZoneLocalizedName> wrapper, IColumnSet<TimeZoneDefinition> columnSet)
            => wrapper.GetRelated(e => e.TimeZoneDefinitionId, columnSet);

    }
    public static class TimeZoneRuleExt
    {
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<TimeZoneRule> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<TimeZoneRule> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<TimeZoneRule> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<TimeZoneRule> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: timezonedefinitionid. Lookup to entity: timezonedefinition.
        /// </summary>
        public static IEntityWrapper<TimeZoneDefinition> GetTimeZoneDefinition(this IEntityWrapperRelation<TimeZoneRule> wrapper, IColumnSet<TimeZoneDefinition> columnSet)
            => wrapper.GetRelated(e => e.TimeZoneDefinitionId, columnSet);

    }
    public static class TopicExt
    {
        /// <summary>
        /// Related attribute: incidentid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetIncidentId(this IEntityWrapperRelation<Topic> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.IncidentId, columnSet);

    }
    public static class TopicHistoryExt
    {
        /// <summary>
        /// Related attribute: topicmodelexecutionhistoryid. Lookup to entity: topicmodelexecutionhistory.
        /// </summary>
        public static IEntityWrapper<TopicModelExecutionHistory> GetTopicModelExecutionHistoryId(this IEntityWrapperRelation<TopicHistory> wrapper, IColumnSet<TopicModelExecutionHistory> columnSet)
            => wrapper.GetRelated(e => e.TopicModelExecutionHistoryId, columnSet);

    }
    public static class TopicModelExt
    {
        /// <summary>
        /// Related attribute: azureserviceconnectionid. Lookup to entity: azureserviceconnection.
        /// </summary>
        public static IEntityWrapper<AzureServiceConnection> GetConnection(this IEntityWrapperRelation<TopicModel> wrapper, IColumnSet<AzureServiceConnection> columnSet)
            => wrapper.GetRelated(e => e.AzureServiceConnectionId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<TopicModel> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: configurationused. Lookup to entity: topicmodelconfiguration.
        /// </summary>
        public static IEntityWrapper<TopicModelConfiguration> GetConfiguration(this IEntityWrapperRelation<TopicModel> wrapper, IColumnSet<TopicModelConfiguration> columnSet)
            => wrapper.GetRelated(e => e.ConfigurationUsed, columnSet);

    }
    public static class TopicModelConfigurationExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<TopicModelConfiguration> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: topicmodelid. Lookup to entity: topicmodel.
        /// </summary>
        public static IEntityWrapper<TopicModel> GetTopicModelId(this IEntityWrapperRelation<TopicModelConfiguration> wrapper, IColumnSet<TopicModel> columnSet)
            => wrapper.GetRelated(e => e.TopicModelId, columnSet);

    }
    public static class TopicModelExecutionHistoryExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<TopicModelExecutionHistory> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: topicmodelid. Lookup to entity: topicmodel.
        /// </summary>
        public static IEntityWrapper<TopicModel> GetTopicModelId(this IEntityWrapperRelation<TopicModelExecutionHistory> wrapper, IColumnSet<TopicModel> columnSet)
            => wrapper.GetRelated(e => e.TopicModelId, columnSet);
        /// <summary>
        /// Related attribute: topicmodelconfigurationid. Lookup to entity: topicmodelconfiguration.
        /// </summary>
        public static IEntityWrapper<TopicModelConfiguration> GetTopicModelConfiguration(this IEntityWrapperRelation<TopicModelExecutionHistory> wrapper, IColumnSet<TopicModelConfiguration> columnSet)
            => wrapper.GetRelated(e => e.TopicModelConfigurationId, columnSet);

    }
    public static class TraceAssociationExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<TraceAssociation> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: tracelogid. Lookup to entity: tracelog.
        /// </summary>
        public static IEntityWrapper<TraceLog> GetTrace(this IEntityWrapperRelation<TraceAssociation> wrapper, IColumnSet<TraceLog> columnSet)
            => wrapper.GetRelated(e => e.TraceLogId, columnSet);

    }
    public static class TraceLogExt
    {
        /// <summary>
        /// Related attribute: regardingobjectowningbusinessunit. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetOwningBusinessUnit(this IEntityWrapperRelation<TraceLog> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectOwningBusinessUnit, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: emailserverprofile.
        /// </summary>
        public static IEntityWrapper<EmailServerProfile> GetRegarding(this IEntityWrapperRelation<TraceLog> wrapper, IColumnSet<EmailServerProfile> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: mailbox.
        /// </summary>
        public static IEntityWrapper<Mailbox> GetRegarding(this IEntityWrapperRelation<TraceLog> wrapper, IColumnSet<Mailbox> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<TraceLog> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<TraceLog> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectOwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<TraceLog> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectOwnerId, columnSet);
        /// <summary>
        /// Related attribute: parenttracelogid. Lookup to entity: tracelog.
        /// </summary>
        public static IEntityWrapper<TraceLog> GetParentId(this IEntityWrapperRelation<TraceLog> wrapper, IColumnSet<TraceLog> columnSet)
            => wrapper.GetRelated(e => e.ParentTraceLogId, columnSet);
        /// <summary>
        /// Related attribute: traceregardingid. Lookup to entity: traceregarding.
        /// </summary>
        public static IEntityWrapper<TraceRegarding> GetTraceRegarding(this IEntityWrapperRelation<TraceLog> wrapper, IColumnSet<TraceRegarding> columnSet)
            => wrapper.GetRelated(e => e.TraceRegardingId, columnSet);

    }
    public static class TraceRegardingExt
    {
        /// <summary>
        /// Related attribute: regardingobjectowningbusinessunit. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetOwningBusinessUnit(this IEntityWrapperRelation<TraceRegarding> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectOwningBusinessUnit, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: emailserverprofile.
        /// </summary>
        public static IEntityWrapper<EmailServerProfile> GetRegarding(this IEntityWrapperRelation<TraceRegarding> wrapper, IColumnSet<EmailServerProfile> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectid. Lookup to entity: mailbox.
        /// </summary>
        public static IEntityWrapper<Mailbox> GetRegarding(this IEntityWrapperRelation<TraceRegarding> wrapper, IColumnSet<Mailbox> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<TraceRegarding> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectOwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: regardingobjectownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<TraceRegarding> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.RegardingObjectOwnerId, columnSet);

    }
    public static class TransactionCurrencyExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<TransactionCurrency> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class TransformationMappingExt
    {
        /// <summary>
        /// Related attribute: importmapid. Lookup to entity: importmap.
        /// </summary>
        public static IEntityWrapper<ImportMap> GetDataMap(this IEntityWrapperRelation<TransformationMapping> wrapper, IColumnSet<ImportMap> columnSet)
            => wrapper.GetRelated(e => e.ImportMapId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<TransformationMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<TransformationMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<TransformationMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<TransformationMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);

    }
    public static class TransformationParameterMappingExt
    {
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<TransformationParameterMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<TransformationParameterMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<TransformationParameterMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<TransformationParameterMapping> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: transformationmappingid. Lookup to entity: transformationmapping.
        /// </summary>
        public static IEntityWrapper<TransformationMapping> GetTransformationMappingId(this IEntityWrapperRelation<TransformationParameterMapping> wrapper, IColumnSet<TransformationMapping> columnSet)
            => wrapper.GetRelated(e => e.TransformationMappingId, columnSet);

    }
    public static class TranslationProcessExt
    {
        /// <summary>
        /// Related attribute: knowledgearticleid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetKnowledgeArticleId(this IEntityWrapperRelation<TranslationProcess> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.KnowledgeArticleId, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<TranslationProcess> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: activestageid. Lookup to entity: processstage.
        /// </summary>
        public static IEntityWrapper<ProcessStage> GetActiveStageId(this IEntityWrapperRelation<TranslationProcess> wrapper, IColumnSet<ProcessStage> columnSet)
            => wrapper.GetRelated(e => e.ActiveStageId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<TranslationProcess> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);
        /// <summary>
        /// Related attribute: processid. Lookup to entity: workflow.
        /// </summary>
        public static IEntityWrapper<Workflow> GetProcessId(this IEntityWrapperRelation<TranslationProcess> wrapper, IColumnSet<Workflow> columnSet)
            => wrapper.GetRelated(e => e.ProcessId, columnSet);

    }
    public static class UntrackedEmailExt
    {
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<UntrackedEmail> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class UoMExt
    {
        /// <summary>
        /// Related attribute: createdbyexternalparty. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetCreatedByExternalParty(this IEntityWrapperRelation<UoM> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.CreatedByExternalParty, columnSet);
        /// <summary>
        /// Related attribute: modifiedbyexternalparty. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetModifiedByExternalParty(this IEntityWrapperRelation<UoM> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.ModifiedByExternalParty, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<UoM> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<UoM> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<UoM> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<UoM> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: baseuom. Lookup to entity: uom.
        /// </summary>
        public static IEntityWrapper<UoM> GetBaseUnit(this IEntityWrapperRelation<UoM> wrapper, IColumnSet<UoM> columnSet)
            => wrapper.GetRelated(e => e.BaseUoM, columnSet);
        /// <summary>
        /// Related attribute: uomscheduleid. Lookup to entity: uomschedule.
        /// </summary>
        public static IEntityWrapper<UoMSchedule> GetUnitSchedule(this IEntityWrapperRelation<UoM> wrapper, IColumnSet<UoMSchedule> columnSet)
            => wrapper.GetRelated(e => e.UoMScheduleId, columnSet);

    }
    public static class UoMScheduleExt
    {
        /// <summary>
        /// Related attribute: createdbyexternalparty. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetCreatedByExternalParty(this IEntityWrapperRelation<UoMSchedule> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.CreatedByExternalParty, columnSet);
        /// <summary>
        /// Related attribute: modifiedbyexternalparty. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetModifiedByExternalParty(this IEntityWrapperRelation<UoMSchedule> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.ModifiedByExternalParty, columnSet);
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<UoMSchedule> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class UserEntityInstanceDataExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: account.
        /// </summary>
        public static IEntityWrapper<Account> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Account> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: activitymimeattachment.
        /// </summary>
        public static IEntityWrapper<ActivityMimeAttachment> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ActivityMimeAttachment> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: activityparty.
        /// </summary>
        public static IEntityWrapper<ActivityParty> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ActivityParty> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: annotation.
        /// </summary>
        public static IEntityWrapper<Annotation> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Annotation> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: appointment.
        /// </summary>
        public static IEntityWrapper<Appointment> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Appointment> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: asyncoperation.
        /// </summary>
        public static IEntityWrapper<AsyncOperation> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<AsyncOperation> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: attachment.
        /// </summary>
        public static IEntityWrapper<Attachment> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Attachment> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: attributemap.
        /// </summary>
        public static IEntityWrapper<AttributeMap> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<AttributeMap> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: audit.
        /// </summary>
        public static IEntityWrapper<Audit> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Audit> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bookableresource.
        /// </summary>
        public static IEntityWrapper<BookableResource> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<BookableResource> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bookableresourcebooking.
        /// </summary>
        public static IEntityWrapper<BookableResourceBooking> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<BookableResourceBooking> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bookableresourcebookingheader.
        /// </summary>
        public static IEntityWrapper<BookableResourceBookingHeader> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<BookableResourceBookingHeader> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bookableresourcecategory.
        /// </summary>
        public static IEntityWrapper<BookableResourceCategory> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<BookableResourceCategory> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bookableresourcecategoryassn.
        /// </summary>
        public static IEntityWrapper<BookableResourceCategoryAssn> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<BookableResourceCategoryAssn> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bookableresourcecharacteristic.
        /// </summary>
        public static IEntityWrapper<BookableResourceCharacteristic> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<BookableResourceCharacteristic> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bookableresourcegroup.
        /// </summary>
        public static IEntityWrapper<BookableResourceGroup> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<BookableResourceGroup> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bookingstatus.
        /// </summary>
        public static IEntityWrapper<BookingStatus> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<BookingStatus> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bulkdeletefailure.
        /// </summary>
        public static IEntityWrapper<BulkDeleteFailure> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<BulkDeleteFailure> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bulkdeleteoperation.
        /// </summary>
        public static IEntityWrapper<BulkDeleteOperation> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<BulkDeleteOperation> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bulkoperation.
        /// </summary>
        public static IEntityWrapper<BulkOperation> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<BulkOperation> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: bulkoperationlog.
        /// </summary>
        public static IEntityWrapper<BulkOperationLog> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<BulkOperationLog> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: businessunitmap.
        /// </summary>
        public static IEntityWrapper<BusinessUnitMap> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<BusinessUnitMap> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: businessunitnewsarticle.
        /// </summary>
        public static IEntityWrapper<BusinessUnitNewsArticle> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<BusinessUnitNewsArticle> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: calendar.
        /// </summary>
        public static IEntityWrapper<Calendar> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Calendar> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: calendarrule.
        /// </summary>
        public static IEntityWrapper<CalendarRule> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<CalendarRule> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: campaign.
        /// </summary>
        public static IEntityWrapper<Campaign> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Campaign> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: campaignactivity.
        /// </summary>
        public static IEntityWrapper<CampaignActivity> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<CampaignActivity> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: campaignactivityitem.
        /// </summary>
        public static IEntityWrapper<CampaignActivityItem> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<CampaignActivityItem> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: campaignitem.
        /// </summary>
        public static IEntityWrapper<CampaignItem> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<CampaignItem> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: campaignresponse.
        /// </summary>
        public static IEntityWrapper<CampaignResponse> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<CampaignResponse> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: channelaccessprofile.
        /// </summary>
        public static IEntityWrapper<ChannelAccessProfile> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ChannelAccessProfile> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: channelaccessprofilerule.
        /// </summary>
        public static IEntityWrapper<ChannelAccessProfileRule> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ChannelAccessProfileRule> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: characteristic.
        /// </summary>
        public static IEntityWrapper<Characteristic> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Characteristic> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: clientupdate.
        /// </summary>
        public static IEntityWrapper<ClientUpdate> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ClientUpdate> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: columnmapping.
        /// </summary>
        public static IEntityWrapper<ColumnMapping> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ColumnMapping> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: commitment.
        /// </summary>
        public static IEntityWrapper<Commitment> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Commitment> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: competitor.
        /// </summary>
        public static IEntityWrapper<Competitor> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Competitor> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: competitoraddress.
        /// </summary>
        public static IEntityWrapper<CompetitorAddress> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<CompetitorAddress> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: competitorproduct.
        /// </summary>
        public static IEntityWrapper<CompetitorProduct> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<CompetitorProduct> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: competitorsalesliterature.
        /// </summary>
        public static IEntityWrapper<CompetitorSalesLiterature> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<CompetitorSalesLiterature> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: connection.
        /// </summary>
        public static IEntityWrapper<Connection> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Connection> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: connectionrole.
        /// </summary>
        public static IEntityWrapper<ConnectionRole> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ConnectionRole> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: connectionroleassociation.
        /// </summary>
        public static IEntityWrapper<ConnectionRoleAssociation> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ConnectionRoleAssociation> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: connectionroleobjecttypecode.
        /// </summary>
        public static IEntityWrapper<ConnectionRoleObjectTypeCode> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ConnectionRoleObjectTypeCode> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: constraintbasedgroup.
        /// </summary>
        public static IEntityWrapper<ConstraintBasedGroup> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ConstraintBasedGroup> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: contact.
        /// </summary>
        public static IEntityWrapper<Contact> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Contact> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: contract.
        /// </summary>
        public static IEntityWrapper<Contract> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Contract> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: contractdetail.
        /// </summary>
        public static IEntityWrapper<ContractDetail> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ContractDetail> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: contracttemplate.
        /// </summary>
        public static IEntityWrapper<ContractTemplate> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ContractTemplate> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: convertrule.
        /// </summary>
        public static IEntityWrapper<ConvertRule> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ConvertRule> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: customeraddress.
        /// </summary>
        public static IEntityWrapper<CustomerAddress> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<CustomerAddress> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: customeropportunityrole.
        /// </summary>
        public static IEntityWrapper<CustomerOpportunityRole> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<CustomerOpportunityRole> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: customerrelationship.
        /// </summary>
        public static IEntityWrapper<CustomerRelationship> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<CustomerRelationship> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: dependency.
        /// </summary>
        public static IEntityWrapper<Dependency> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Dependency> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: dependencynode.
        /// </summary>
        public static IEntityWrapper<DependencyNode> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<DependencyNode> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: discount.
        /// </summary>
        public static IEntityWrapper<Discount> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Discount> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: discounttype.
        /// </summary>
        public static IEntityWrapper<DiscountType> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<DiscountType> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: displaystring.
        /// </summary>
        public static IEntityWrapper<DisplayString> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<DisplayString> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: displaystringmap.
        /// </summary>
        public static IEntityWrapper<DisplayStringMap> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<DisplayStringMap> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: documentindex.
        /// </summary>
        public static IEntityWrapper<DocumentIndex> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<DocumentIndex> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: duplicaterecord.
        /// </summary>
        public static IEntityWrapper<DuplicateRecord> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<DuplicateRecord> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: duplicaterule.
        /// </summary>
        public static IEntityWrapper<DuplicateRule> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<DuplicateRule> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: duplicaterulecondition.
        /// </summary>
        public static IEntityWrapper<DuplicateRuleCondition> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<DuplicateRuleCondition> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: email.
        /// </summary>
        public static IEntityWrapper<Email> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Email> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: emailhash.
        /// </summary>
        public static IEntityWrapper<EmailHash> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<EmailHash> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: emailsearch.
        /// </summary>
        public static IEntityWrapper<EmailSearch> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<EmailSearch> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: entitlement.
        /// </summary>
        public static IEntityWrapper<Entitlement> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Entitlement> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: entitlementchannel.
        /// </summary>
        public static IEntityWrapper<EntitlementChannel> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<EntitlementChannel> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: entitlementtemplate.
        /// </summary>
        public static IEntityWrapper<EntitlementTemplate> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<EntitlementTemplate> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: entitymap.
        /// </summary>
        public static IEntityWrapper<EntityMap> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<EntityMap> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: equipment.
        /// </summary>
        public static IEntityWrapper<Equipment> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Equipment> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: externalparty.
        /// </summary>
        public static IEntityWrapper<ExternalParty> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ExternalParty> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: fax.
        /// </summary>
        public static IEntityWrapper<Fax> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Fax> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: fieldpermission.
        /// </summary>
        public static IEntityWrapper<FieldPermission> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<FieldPermission> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: fieldsecurityprofile.
        /// </summary>
        public static IEntityWrapper<FieldSecurityProfile> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<FieldSecurityProfile> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: filtertemplate.
        /// </summary>
        public static IEntityWrapper<FilterTemplate> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<FilterTemplate> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: goal.
        /// </summary>
        public static IEntityWrapper<Goal> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Goal> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: goalrollupquery.
        /// </summary>
        public static IEntityWrapper<GoalRollupQuery> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<GoalRollupQuery> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: import.
        /// </summary>
        public static IEntityWrapper<Import> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Import> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: importdata.
        /// </summary>
        public static IEntityWrapper<ImportData> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ImportData> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: importentitymapping.
        /// </summary>
        public static IEntityWrapper<ImportEntityMapping> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ImportEntityMapping> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: importfile.
        /// </summary>
        public static IEntityWrapper<ImportFile> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ImportFile> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: importjob.
        /// </summary>
        public static IEntityWrapper<ImportJob> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ImportJob> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: importlog.
        /// </summary>
        public static IEntityWrapper<ImportLog> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ImportLog> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: importmap.
        /// </summary>
        public static IEntityWrapper<ImportMap> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ImportMap> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: incident.
        /// </summary>
        public static IEntityWrapper<Incident> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Incident> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: incidentresolution.
        /// </summary>
        public static IEntityWrapper<IncidentResolution> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<IncidentResolution> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: ins_salesorder.
        /// </summary>
        public static IEntityWrapper<ins_salesorder> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ins_salesorder> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: ins_salesorderline.
        /// </summary>
        public static IEntityWrapper<ins_salesorderline> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ins_salesorderline> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: internaladdress.
        /// </summary>
        public static IEntityWrapper<InternalAddress> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<InternalAddress> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: invaliddependency.
        /// </summary>
        public static IEntityWrapper<InvalidDependency> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<InvalidDependency> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: invoice.
        /// </summary>
        public static IEntityWrapper<Invoice> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Invoice> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: invoicedetail.
        /// </summary>
        public static IEntityWrapper<InvoiceDetail> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<InvoiceDetail> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: isvconfig.
        /// </summary>
        public static IEntityWrapper<IsvConfig> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<IsvConfig> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: kbarticle.
        /// </summary>
        public static IEntityWrapper<KbArticle> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<KbArticle> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: kbarticlecomment.
        /// </summary>
        public static IEntityWrapper<KbArticleComment> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<KbArticleComment> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: kbarticletemplate.
        /// </summary>
        public static IEntityWrapper<KbArticleTemplate> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<KbArticleTemplate> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: knowledgearticle.
        /// </summary>
        public static IEntityWrapper<KnowledgeArticle> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<KnowledgeArticle> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: knowledgebaserecord.
        /// </summary>
        public static IEntityWrapper<KnowledgeBaseRecord> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<KnowledgeBaseRecord> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: lead.
        /// </summary>
        public static IEntityWrapper<Lead> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Lead> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: leadaddress.
        /// </summary>
        public static IEntityWrapper<LeadAddress> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<LeadAddress> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: leadproduct.
        /// </summary>
        public static IEntityWrapper<LeadProduct> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<LeadProduct> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: letter.
        /// </summary>
        public static IEntityWrapper<Letter> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Letter> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: license.
        /// </summary>
        public static IEntityWrapper<License> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<License> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: list.
        /// </summary>
        public static IEntityWrapper<List> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<List> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: listmember.
        /// </summary>
        public static IEntityWrapper<ListMember> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ListMember> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: lookupmapping.
        /// </summary>
        public static IEntityWrapper<LookUpMapping> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<LookUpMapping> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: mailbox.
        /// </summary>
        public static IEntityWrapper<Mailbox> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Mailbox> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: mailmergetemplate.
        /// </summary>
        public static IEntityWrapper<MailMergeTemplate> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<MailMergeTemplate> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: metric.
        /// </summary>
        public static IEntityWrapper<Metric> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Metric> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: msdyn_postalbum.
        /// </summary>
        public static IEntityWrapper<msdyn_PostAlbum> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<msdyn_PostAlbum> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: msdyn_postconfig.
        /// </summary>
        public static IEntityWrapper<msdyn_PostConfig> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<msdyn_PostConfig> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: msdyn_postruleconfig.
        /// </summary>
        public static IEntityWrapper<msdyn_PostRuleConfig> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<msdyn_PostRuleConfig> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: msdyn_wallsavedquery.
        /// </summary>
        public static IEntityWrapper<msdyn_wallsavedquery> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<msdyn_wallsavedquery> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: msdyn_wallsavedqueryusersettings.
        /// </summary>
        public static IEntityWrapper<msdyn_wallsavedqueryusersettings> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<msdyn_wallsavedqueryusersettings> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: notification.
        /// </summary>
        public static IEntityWrapper<Notification> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Notification> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: opportunity.
        /// </summary>
        public static IEntityWrapper<Opportunity> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Opportunity> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: opportunityclose.
        /// </summary>
        public static IEntityWrapper<OpportunityClose> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<OpportunityClose> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: opportunityproduct.
        /// </summary>
        public static IEntityWrapper<OpportunityProduct> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<OpportunityProduct> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: orderclose.
        /// </summary>
        public static IEntityWrapper<OrderClose> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<OrderClose> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: organizationstatistic.
        /// </summary>
        public static IEntityWrapper<OrganizationStatistic> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<OrganizationStatistic> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: ownermapping.
        /// </summary>
        public static IEntityWrapper<OwnerMapping> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<OwnerMapping> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: phonecall.
        /// </summary>
        public static IEntityWrapper<PhoneCall> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<PhoneCall> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: picklistmapping.
        /// </summary>
        public static IEntityWrapper<PickListMapping> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<PickListMapping> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: pluginassembly.
        /// </summary>
        public static IEntityWrapper<PluginAssembly> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<PluginAssembly> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: plugintype.
        /// </summary>
        public static IEntityWrapper<PluginType> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<PluginType> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: plugintypestatistic.
        /// </summary>
        public static IEntityWrapper<PluginTypeStatistic> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<PluginTypeStatistic> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: pricelevel.
        /// </summary>
        public static IEntityWrapper<PriceLevel> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<PriceLevel> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: principalattributeaccessmap.
        /// </summary>
        public static IEntityWrapper<PrincipalAttributeAccessMap> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<PrincipalAttributeAccessMap> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: principalentitymap.
        /// </summary>
        public static IEntityWrapper<PrincipalEntityMap> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<PrincipalEntityMap> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: principalobjectaccess.
        /// </summary>
        public static IEntityWrapper<PrincipalObjectAccess> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<PrincipalObjectAccess> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: principalobjectattributeaccess.
        /// </summary>
        public static IEntityWrapper<PrincipalObjectAttributeAccess> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<PrincipalObjectAttributeAccess> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: privilege.
        /// </summary>
        public static IEntityWrapper<Privilege> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Privilege> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: processsession.
        /// </summary>
        public static IEntityWrapper<ProcessSession> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ProcessSession> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: product.
        /// </summary>
        public static IEntityWrapper<Product> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Product> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: productassociation.
        /// </summary>
        public static IEntityWrapper<ProductAssociation> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ProductAssociation> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: productpricelevel.
        /// </summary>
        public static IEntityWrapper<ProductPriceLevel> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ProductPriceLevel> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: productsalesliterature.
        /// </summary>
        public static IEntityWrapper<ProductSalesLiterature> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ProductSalesLiterature> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: publisher.
        /// </summary>
        public static IEntityWrapper<Publisher> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Publisher> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: publisheraddress.
        /// </summary>
        public static IEntityWrapper<PublisherAddress> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<PublisherAddress> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: queue.
        /// </summary>
        public static IEntityWrapper<Queue> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Queue> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: queueitem.
        /// </summary>
        public static IEntityWrapper<QueueItem> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<QueueItem> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: quote.
        /// </summary>
        public static IEntityWrapper<Quote> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Quote> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: quoteclose.
        /// </summary>
        public static IEntityWrapper<QuoteClose> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<QuoteClose> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: quotedetail.
        /// </summary>
        public static IEntityWrapper<QuoteDetail> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<QuoteDetail> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: ratingmodel.
        /// </summary>
        public static IEntityWrapper<RatingModel> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<RatingModel> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: ratingvalue.
        /// </summary>
        public static IEntityWrapper<RatingValue> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<RatingValue> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: recurringappointmentmaster.
        /// </summary>
        public static IEntityWrapper<RecurringAppointmentMaster> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<RecurringAppointmentMaster> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: relationshiprole.
        /// </summary>
        public static IEntityWrapper<RelationshipRole> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<RelationshipRole> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: relationshiprolemap.
        /// </summary>
        public static IEntityWrapper<RelationshipRoleMap> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<RelationshipRoleMap> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: report.
        /// </summary>
        public static IEntityWrapper<Report> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Report> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: reportcategory.
        /// </summary>
        public static IEntityWrapper<ReportCategory> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ReportCategory> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: reportentity.
        /// </summary>
        public static IEntityWrapper<ReportEntity> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ReportEntity> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: reportlink.
        /// </summary>
        public static IEntityWrapper<ReportLink> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ReportLink> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: reportvisibility.
        /// </summary>
        public static IEntityWrapper<ReportVisibility> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ReportVisibility> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: resource.
        /// </summary>
        public static IEntityWrapper<Resource> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Resource> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: resourcegroup.
        /// </summary>
        public static IEntityWrapper<ResourceGroup> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ResourceGroup> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: resourcegroupexpansion.
        /// </summary>
        public static IEntityWrapper<ResourceGroupExpansion> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ResourceGroupExpansion> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: resourcespec.
        /// </summary>
        public static IEntityWrapper<ResourceSpec> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ResourceSpec> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: ribboncommand.
        /// </summary>
        public static IEntityWrapper<RibbonCommand> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<RibbonCommand> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: ribboncontextgroup.
        /// </summary>
        public static IEntityWrapper<RibbonContextGroup> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<RibbonContextGroup> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: ribboncustomization.
        /// </summary>
        public static IEntityWrapper<RibbonCustomization> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<RibbonCustomization> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: ribbondiff.
        /// </summary>
        public static IEntityWrapper<RibbonDiff> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<RibbonDiff> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: ribbonrule.
        /// </summary>
        public static IEntityWrapper<RibbonRule> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<RibbonRule> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: ribbontabtocommandmap.
        /// </summary>
        public static IEntityWrapper<RibbonTabToCommandMap> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<RibbonTabToCommandMap> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: role.
        /// </summary>
        public static IEntityWrapper<Role> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Role> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: roletemplate.
        /// </summary>
        public static IEntityWrapper<RoleTemplate> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<RoleTemplate> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: rollupfield.
        /// </summary>
        public static IEntityWrapper<RollupField> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<RollupField> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: routingrule.
        /// </summary>
        public static IEntityWrapper<RoutingRule> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<RoutingRule> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: routingruleitem.
        /// </summary>
        public static IEntityWrapper<RoutingRuleItem> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<RoutingRuleItem> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: salesliterature.
        /// </summary>
        public static IEntityWrapper<SalesLiterature> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SalesLiterature> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: salesliteratureitem.
        /// </summary>
        public static IEntityWrapper<SalesLiteratureItem> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SalesLiteratureItem> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: salesorder.
        /// </summary>
        public static IEntityWrapper<SalesOrder> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SalesOrder> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: salesorderdetail.
        /// </summary>
        public static IEntityWrapper<SalesOrderDetail> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SalesOrderDetail> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: salesprocessinstance.
        /// </summary>
        public static IEntityWrapper<SalesProcessInstance> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SalesProcessInstance> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: savedquery.
        /// </summary>
        public static IEntityWrapper<SavedQuery> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SavedQuery> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: savedqueryvisualization.
        /// </summary>
        public static IEntityWrapper<SavedQueryVisualization> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SavedQueryVisualization> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: sdkmessage.
        /// </summary>
        public static IEntityWrapper<SdkMessage> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SdkMessage> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: sdkmessagefilter.
        /// </summary>
        public static IEntityWrapper<SdkMessageFilter> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SdkMessageFilter> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: sdkmessagepair.
        /// </summary>
        public static IEntityWrapper<SdkMessagePair> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SdkMessagePair> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: sdkmessageprocessingstep.
        /// </summary>
        public static IEntityWrapper<SdkMessageProcessingStep> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SdkMessageProcessingStep> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: sdkmessageprocessingstepimage.
        /// </summary>
        public static IEntityWrapper<SdkMessageProcessingStepImage> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SdkMessageProcessingStepImage> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: sdkmessageprocessingstepsecureconfig.
        /// </summary>
        public static IEntityWrapper<SdkMessageProcessingStepSecureConfig> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SdkMessageProcessingStepSecureConfig> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: sdkmessagerequest.
        /// </summary>
        public static IEntityWrapper<SdkMessageRequest> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SdkMessageRequest> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: sdkmessagerequestfield.
        /// </summary>
        public static IEntityWrapper<SdkMessageRequestField> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SdkMessageRequestField> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: sdkmessageresponse.
        /// </summary>
        public static IEntityWrapper<SdkMessageResponse> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SdkMessageResponse> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: sdkmessageresponsefield.
        /// </summary>
        public static IEntityWrapper<SdkMessageResponseField> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SdkMessageResponseField> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: service.
        /// </summary>
        public static IEntityWrapper<Service> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Service> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: serviceappointment.
        /// </summary>
        public static IEntityWrapper<ServiceAppointment> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ServiceAppointment> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: serviceendpoint.
        /// </summary>
        public static IEntityWrapper<ServiceEndpoint> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<ServiceEndpoint> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: sharepointdocumentlocation.
        /// </summary>
        public static IEntityWrapper<SharePointDocumentLocation> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SharePointDocumentLocation> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: sharepointsite.
        /// </summary>
        public static IEntityWrapper<SharePointSite> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SharePointSite> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: site.
        /// </summary>
        public static IEntityWrapper<Site> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Site> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: sitemap.
        /// </summary>
        public static IEntityWrapper<SiteMap> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SiteMap> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: sla.
        /// </summary>
        public static IEntityWrapper<SLA> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SLA> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: socialactivity.
        /// </summary>
        public static IEntityWrapper<SocialActivity> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SocialActivity> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: solution.
        /// </summary>
        public static IEntityWrapper<Solution> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Solution> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: solutioncomponent.
        /// </summary>
        public static IEntityWrapper<SolutionComponent> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SolutionComponent> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: statusmap.
        /// </summary>
        public static IEntityWrapper<StatusMap> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<StatusMap> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: stringmap.
        /// </summary>
        public static IEntityWrapper<StringMap> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<StringMap> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: subject.
        /// </summary>
        public static IEntityWrapper<Subject> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Subject> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: subscription.
        /// </summary>
        public static IEntityWrapper<Subscription> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Subscription> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: subscriptionmanuallytrackedobject.
        /// </summary>
        public static IEntityWrapper<SubscriptionManuallyTrackedObject> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SubscriptionManuallyTrackedObject> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: subscriptionsyncinfo.
        /// </summary>
        public static IEntityWrapper<SubscriptionSyncInfo> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SubscriptionSyncInfo> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: systemuserbusinessunitentitymap.
        /// </summary>
        public static IEntityWrapper<SystemUserBusinessUnitEntityMap> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<SystemUserBusinessUnitEntityMap> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: task.
        /// </summary>
        public static IEntityWrapper<Task> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Task> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: teammembership.
        /// </summary>
        public static IEntityWrapper<TeamMembership> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<TeamMembership> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: template.
        /// </summary>
        public static IEntityWrapper<Template> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Template> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: territory.
        /// </summary>
        public static IEntityWrapper<Territory> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Territory> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: theme.
        /// </summary>
        public static IEntityWrapper<Theme> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Theme> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: timezonedefinition.
        /// </summary>
        public static IEntityWrapper<TimeZoneDefinition> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<TimeZoneDefinition> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: timezonelocalizedname.
        /// </summary>
        public static IEntityWrapper<TimeZoneLocalizedName> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<TimeZoneLocalizedName> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: timezonerule.
        /// </summary>
        public static IEntityWrapper<TimeZoneRule> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<TimeZoneRule> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: transformationmapping.
        /// </summary>
        public static IEntityWrapper<TransformationMapping> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<TransformationMapping> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: transformationparametermapping.
        /// </summary>
        public static IEntityWrapper<TransformationParameterMapping> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<TransformationParameterMapping> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: unresolvedaddress.
        /// </summary>
        public static IEntityWrapper<UnresolvedAddress> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<UnresolvedAddress> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: uom.
        /// </summary>
        public static IEntityWrapper<UoM> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<UoM> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: uomschedule.
        /// </summary>
        public static IEntityWrapper<UoMSchedule> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<UoMSchedule> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: userentityuisettings.
        /// </summary>
        public static IEntityWrapper<UserEntityUISettings> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<UserEntityUISettings> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: userfiscalcalendar.
        /// </summary>
        public static IEntityWrapper<UserFiscalCalendar> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<UserFiscalCalendar> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: userform.
        /// </summary>
        public static IEntityWrapper<UserForm> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<UserForm> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: usermapping.
        /// </summary>
        public static IEntityWrapper<UserMapping> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<UserMapping> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: userquery.
        /// </summary>
        public static IEntityWrapper<UserQuery> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<UserQuery> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: userqueryvisualization.
        /// </summary>
        public static IEntityWrapper<UserQueryVisualization> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<UserQueryVisualization> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: webresource.
        /// </summary>
        public static IEntityWrapper<WebResource> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<WebResource> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: webwizard.
        /// </summary>
        public static IEntityWrapper<WebWizard> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<WebWizard> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: wizardaccessprivilege.
        /// </summary>
        public static IEntityWrapper<WizardAccessPrivilege> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<WizardAccessPrivilege> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: wizardpage.
        /// </summary>
        public static IEntityWrapper<WizardPage> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<WizardPage> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: workflow.
        /// </summary>
        public static IEntityWrapper<Workflow> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<Workflow> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: workflowdependency.
        /// </summary>
        public static IEntityWrapper<WorkflowDependency> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<WorkflowDependency> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: workflowlog.
        /// </summary>
        public static IEntityWrapper<WorkflowLog> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<WorkflowLog> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: objectid. Lookup to entity: workflowwaitsubscription.
        /// </summary>
        public static IEntityWrapper<WorkflowWaitSubscription> GetObjectId(this IEntityWrapperRelation<UserEntityInstanceData> wrapper, IColumnSet<WorkflowWaitSubscription> columnSet)
            => wrapper.GetRelated(e => e.ObjectId, columnSet);

    }
    public static class UserFiscalCalendarExt
    {
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<UserFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<UserFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<UserFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<UserFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: salespersonid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetSalesPersonId(this IEntityWrapperRelation<UserFiscalCalendar> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.SalesPersonId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<UserFiscalCalendar> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class UserMappingExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganizationId(this IEntityWrapperRelation<UserMapping> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<UserMapping> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class UserQueryExt
    {

    }
    public static class UserQueryVisualizationExt
    {
        /// <summary>
        /// Related attribute: webresourceid. Lookup to entity: webresource.
        /// </summary>
        public static IEntityWrapper<WebResource> GetWebResource(this IEntityWrapperRelation<UserQueryVisualization> wrapper, IColumnSet<WebResource> columnSet)
            => wrapper.GetRelated(e => e.WebResourceId, columnSet);

    }
    public static class UserSettingsExt
    {
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<UserSettings> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<UserSettings> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<UserSettings> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<UserSettings> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: transactioncurrencyid. Lookup to entity: transactioncurrency.
        /// </summary>
        public static IEntityWrapper<TransactionCurrency> GetCurrency(this IEntityWrapperRelation<UserSettings> wrapper, IColumnSet<TransactionCurrency> columnSet)
            => wrapper.GetRelated(e => e.TransactionCurrencyId, columnSet);

    }
    public static class WebResourceExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<WebResource> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class WebWizardExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<WebWizard> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);

    }
    public static class WizardAccessPrivilegeExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<WizardAccessPrivilege> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: webwizardid. Lookup to entity: webwizard.
        /// </summary>
        public static IEntityWrapper<WebWizard> GetWizardID(this IEntityWrapperRelation<WizardAccessPrivilege> wrapper, IColumnSet<WebWizard> columnSet)
            => wrapper.GetRelated(e => e.WebWizardId, columnSet);

    }
    public static class WizardPageExt
    {
        /// <summary>
        /// Related attribute: organizationid. Lookup to entity: organization.
        /// </summary>
        public static IEntityWrapper<Organization> GetOrganization(this IEntityWrapperRelation<WizardPage> wrapper, IColumnSet<Organization> columnSet)
            => wrapper.GetRelated(e => e.OrganizationId, columnSet);
        /// <summary>
        /// Related attribute: webwizardid. Lookup to entity: webwizard.
        /// </summary>
        public static IEntityWrapper<WebWizard> GetWizardID(this IEntityWrapperRelation<WizardPage> wrapper, IColumnSet<WebWizard> columnSet)
            => wrapper.GetRelated(e => e.WebWizardId, columnSet);

    }
    public static class WorkflowExt
    {
        /// <summary>
        /// Related attribute: sdkmessageid. Lookup to entity: sdkmessage.
        /// </summary>
        public static IEntityWrapper<SdkMessage> GetSDKMessage(this IEntityWrapperRelation<Workflow> wrapper, IColumnSet<SdkMessage> columnSet)
            => wrapper.GetRelated(e => e.SdkMessageId, columnSet);
        /// <summary>
        /// Related attribute: plugintypeid. Lookup to entity: sdkmessagefilter.
        /// </summary>
        public static IEntityWrapper<SdkMessageFilter> GetPluginTypeId(this IEntityWrapperRelation<Workflow> wrapper, IColumnSet<SdkMessageFilter> columnSet)
            => wrapper.GetRelated(e => e.PluginTypeId, columnSet);
        /// <summary>
        /// Related attribute: activeworkflowid. Lookup to entity: workflow.
        /// </summary>
        public static IEntityWrapper<Workflow> GetActiveProcessID(this IEntityWrapperRelation<Workflow> wrapper, IColumnSet<Workflow> columnSet)
            => wrapper.GetRelated(e => e.ActiveWorkflowId, columnSet);
        /// <summary>
        /// Related attribute: parentworkflowid. Lookup to entity: workflow.
        /// </summary>
        public static IEntityWrapper<Workflow> GetParentProcessID(this IEntityWrapperRelation<Workflow> wrapper, IColumnSet<Workflow> columnSet)
            => wrapper.GetRelated(e => e.ParentWorkflowId, columnSet);

    }
    public static class WorkflowDependencyExt
    {
        /// <summary>
        /// Related attribute: sdkmessageid. Lookup to entity: sdkmessage.
        /// </summary>
        public static IEntityWrapper<SdkMessage> GetSdkMessageId(this IEntityWrapperRelation<WorkflowDependency> wrapper, IColumnSet<SdkMessage> columnSet)
            => wrapper.GetRelated(e => e.SdkMessageId, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<WorkflowDependency> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<WorkflowDependency> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<WorkflowDependency> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<WorkflowDependency> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<WorkflowDependency> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<WorkflowDependency> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Related attribute: workflowid. Lookup to entity: workflow.
        /// </summary>
        public static IEntityWrapper<Workflow> GetProcess(this IEntityWrapperRelation<WorkflowDependency> wrapper, IColumnSet<Workflow> columnSet)
            => wrapper.GetRelated(e => e.WorkflowId, columnSet);

    }
    public static class WorkflowLogExt
    {
        /// <summary>
        /// Multi lookup attribute. Related attribute: asyncoperationid. Lookup to entity: asyncoperation.
        /// </summary>
        public static IEntityWrapper<AsyncOperation> GetParentRecord(this IEntityWrapperRelation<WorkflowLog> wrapper, IColumnSet<AsyncOperation> columnSet)
            => wrapper.GetRelated(e => e.AsyncOperationId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: asyncoperationid. Lookup to entity: processsession.
        /// </summary>
        public static IEntityWrapper<ProcessSession> GetParentRecord(this IEntityWrapperRelation<WorkflowLog> wrapper, IColumnSet<ProcessSession> columnSet)
            => wrapper.GetRelated(e => e.AsyncOperationId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: childworkflowinstanceid. Lookup to entity: asyncoperation.
        /// </summary>
        public static IEntityWrapper<AsyncOperation> GetChildWorkflowSystemJob(this IEntityWrapperRelation<WorkflowLog> wrapper, IColumnSet<AsyncOperation> columnSet)
            => wrapper.GetRelated(e => e.ChildWorkflowInstanceId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: childworkflowinstanceid. Lookup to entity: processsession.
        /// </summary>
        public static IEntityWrapper<ProcessSession> GetChildWorkflowSystemJob(this IEntityWrapperRelation<WorkflowLog> wrapper, IColumnSet<ProcessSession> columnSet)
            => wrapper.GetRelated(e => e.ChildWorkflowInstanceId, columnSet);
        /// <summary>
        /// Related attribute: owningbusinessunit. Lookup to entity: businessunit.
        /// </summary>
        public static IEntityWrapper<BusinessUnit> GetOwningBusinessUnit(this IEntityWrapperRelation<WorkflowLog> wrapper, IColumnSet<BusinessUnit> columnSet)
            => wrapper.GetRelated(e => e.OwningBusinessUnit, columnSet);
        /// <summary>
        /// Related attribute: createdby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedBy(this IEntityWrapperRelation<WorkflowLog> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedBy, columnSet);
        /// <summary>
        /// Related attribute: createdonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetCreatedByDelegate(this IEntityWrapperRelation<WorkflowLog> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.CreatedOnBehalfBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedBy(this IEntityWrapperRelation<WorkflowLog> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedBy, columnSet);
        /// <summary>
        /// Related attribute: modifiedonbehalfby. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetModifiedByDelegate(this IEntityWrapperRelation<WorkflowLog> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.ModifiedOnBehalfBy, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<WorkflowLog> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<WorkflowLog> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Related attribute: owninguser. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwningUser(this IEntityWrapperRelation<WorkflowLog> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwningUser, columnSet);
        /// <summary>
        /// Related attribute: owningteam. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwningTeam(this IEntityWrapperRelation<WorkflowLog> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwningTeam, columnSet);

    }
    public static class WorkflowWaitSubscriptionExt
    {
        /// <summary>
        /// Related attribute: asyncoperationid. Lookup to entity: asyncoperation.
        /// </summary>
        public static IEntityWrapper<AsyncOperation> GetAsyncOperationId(this IEntityWrapperRelation<WorkflowWaitSubscription> wrapper, IColumnSet<AsyncOperation> columnSet)
            => wrapper.GetRelated(e => e.AsyncOperationId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: systemuser.
        /// </summary>
        public static IEntityWrapper<SystemUser> GetOwner(this IEntityWrapperRelation<WorkflowWaitSubscription> wrapper, IColumnSet<SystemUser> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);
        /// <summary>
        /// Multi lookup attribute. Related attribute: ownerid. Lookup to entity: team.
        /// </summary>
        public static IEntityWrapper<Team> GetOwner(this IEntityWrapperRelation<WorkflowWaitSubscription> wrapper, IColumnSet<Team> columnSet)
            => wrapper.GetRelated(e => e.OwnerId, columnSet);

    }

}
