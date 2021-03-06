USE [Contacts]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 08/27/2018 12:56:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Contacts]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Contacts](
	[ContactId] [uniqueidentifier] NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[PhoneNumber] [varchar](15) NOT NULL,
	[Status] [bit] NOT NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[ContactId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [Email], [PhoneNumber], [Status], [CreateDate]) VALUES (N'e955b07a-a75c-4d4d-9610-083edf01c70f', N'Harsh', N'Harsh', N'Harsh@Harsh.com', N'142555871', 1, CAST(0x0000A94900C73D9F AS DateTime))
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [Email], [PhoneNumber], [Status], [CreateDate]) VALUES (N'a25fd1d7-d048-4ab1-9b51-09e4ce1f99f3', N'Rajesh', N'Rajesh', N'Rajesh@Rajesh.com', N'2596314', 1, CAST(0x0000A94900C8DB93 AS DateTime))
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [Email], [PhoneNumber], [Status], [CreateDate]) VALUES (N'3eaf8044-4398-4034-af75-48f15285c704', N'Samir', N'Samir', N'Samir@Samir.com', N'3698574', 1, CAST(0x0000A94900BFB28A AS DateTime))
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [Email], [PhoneNumber], [Status], [CreateDate]) VALUES (N'bcb4343b-ed57-4f6b-8eb4-57703e02e5de', N'Ajay', N'Ajay', N'Ajay@Ajay.com', N'25698741', 1, CAST(0x0000A94900BFDA4B AS DateTime))
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [Email], [PhoneNumber], [Status], [CreateDate]) VALUES (N'4aabd722-2695-4192-b53f-5cbfe4709cc5', N'Dinesh', N'Kanojia', N'utkarshtripathi26@gmail.com', N'09819646351', 1, CAST(0x0000A94900BF6A09 AS DateTime))
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [Email], [PhoneNumber], [Status], [CreateDate]) VALUES (N'71daaee5-ac53-4f71-8580-616446ab9830', N'Sonali', N'Sonali', N'Sonali@Sonali.com', N'142536987', 1, CAST(0x0000A94900BF7D94 AS DateTime))
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [Email], [PhoneNumber], [Status], [CreateDate]) VALUES (N'50b06066-692b-433d-94dd-61a8af1462ad', N'Rucha', N'Rucha', N'Rucha@Rucha.com', N'3659874', 1, CAST(0x0000A94900BFF9DE AS DateTime))
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [Email], [PhoneNumber], [Status], [CreateDate]) VALUES (N'cedb2fda-0ef6-4a4b-90be-71095564f604', N'Archana', N'Archana', N'Archana@Archana.com', N'25639871', 1, CAST(0x0000A94900CD125A AS DateTime))
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [Email], [PhoneNumber], [Status], [CreateDate]) VALUES (N'd3a735ca-b4ed-412d-bd4f-8a51e19b33fd', N'Deepak', N'Deepak', N'Deepak@Deepak.com', N'3659874152', 1, CAST(0x0000A94900BF90F8 AS DateTime))
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [Email], [PhoneNumber], [Status], [CreateDate]) VALUES (N'a8c29979-28b7-42de-83e0-9ad734705cda', N'Meenakshi', N'Meenakshi', N'Meenakshi@Meenakshi.com', N'326541789', 1, CAST(0x0000A94900CA856A AS DateTime))
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [Email], [PhoneNumber], [Status], [CreateDate]) VALUES (N'fea5fb3a-f180-45ef-9920-9f1454ab9e5b', N'Manisha', N'Manisha', N'Manisha@Manisha.com', N'56987412', 1, CAST(0x0000A94900C01B96 AS DateTime))
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [Email], [PhoneNumber], [Status], [CreateDate]) VALUES (N'c9753637-74e6-4f20-bbe8-bb1a4d1d61d9', N'Santosh', N'Gupta', N'utkarshtripathi26@gmail.com', N'09819646351', 1, CAST(0x0000A94900BF5F15 AS DateTime))
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [Email], [PhoneNumber], [Status], [CreateDate]) VALUES (N'd18f63bb-0469-4a5e-a366-c05ac225e58d', N'Sanchita', N'Sanchita', N'Sanchita@Sanchita.com', N'12365478', 1, CAST(0x0000A94900BFA146 AS DateTime))
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [Email], [PhoneNumber], [Status], [CreateDate]) VALUES (N'a3eb6b88-a85a-4180-86d8-cbb76d6a85ca', N'Kavya', N'Kavya', N'Kavya@Kavya.com', N'145263985', 1, CAST(0x0000A94900C70E30 AS DateTime))
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [Email], [PhoneNumber], [Status], [CreateDate]) VALUES (N'ff65981b-8108-4588-8bbd-e7e8ff72fad6', N'Ritika', N'Ritika', N'Ritika@Ritika.com', N'253641789', 1, CAST(0x0000A94900CB0B34 AS DateTime))
/****** Object:  Default [DF__Contacts__Create__023D5A04]    Script Date: 08/27/2018 12:56:13 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__Contacts__Create__023D5A04]') AND parent_object_id = OBJECT_ID(N'[dbo].[Contacts]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__Contacts__Create__023D5A04]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Contacts] ADD  DEFAULT (getdate()) FOR [CreateDate]
END


End
GO
