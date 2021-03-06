﻿CREATE TABLE [dbo].[ORDERS] (
    [ID]                 INT            IDENTITY (1, 1) NOT NULL,
    [DateCreated]        SMALLDATETIME  CONSTRAINT [DF_PURCHASE_DateCreated] DEFAULT (getdate()) NOT NULL,
    [DateShipped]        SMALLDATETIME  NULL,
    [Verified]           BIT            CONSTRAINT [DF_ORDERS_Verified] DEFAULT ((0)) NOT NULL,
    [Completed]          BIT            CONSTRAINT [DF_ORDERS_Completed] DEFAULT ((0)) NOT NULL,
    [Canceled]           BIT            CONSTRAINT [DF_ORDERS_Canceled] DEFAULT ((0)) NOT NULL,
    [Comments]           VARCHAR (1000) NULL,
    [CustomerID]         INT            NULL,
    [ShippingID]         INT            NULL,
    [AmountPaid]         DECIMAL (6, 2) CONSTRAINT [DF_ORDERS_AmountPaid] DEFAULT ((0)) NOT NULL,
    [BonusUsed]          DECIMAL (6, 2) CONSTRAINT [DF_ORDERS_BonusUsed] DEFAULT ((0)) NULL,
    [ShippingAddress]    INT            NULL,
    [BillingAddress]     INT            NULL,
    [Status]             INT            CONSTRAINT [DF_ORDERS_Status] DEFAULT ((1)) NULL,
    [ShippingDetails]    VARCHAR (150)  NULL,
    [TotalAmount]        DECIMAL (6, 2) CONSTRAINT [DF_ORDERS_TotalAmount] DEFAULT ((0)) NOT NULL,
    [DateDelivered]      SMALLDATETIME  NULL,
    [TrackingNumber]     VARCHAR (50)   NULL,
    [VerificationNumber] CHAR (20)      NULL,
    CONSTRAINT [PK_PURCHASE] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_ORDERS_ADDRESSINFO] FOREIGN KEY ([ShippingAddress]) REFERENCES [dbo].[ADDRESSINFO] ([ID]),
    CONSTRAINT [FK_ORDERS_ADDRESSINFO1] FOREIGN KEY ([BillingAddress]) REFERENCES [dbo].[ADDRESSINFO] ([ID]),
    CONSTRAINT [FK_ORDERS_CUSTOMER] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[CUSTOMER] ([ID]),
    CONSTRAINT [FK_ORDERS_D_ORDER_STATUS] FOREIGN KEY ([Status]) REFERENCES [dbo].[D_ORDER_STATUS] ([ID]),
    CONSTRAINT [FK_ORDERS_SHIPPING] FOREIGN KEY ([ShippingID]) REFERENCES [dbo].[SHIPPING] ([ID])
);

