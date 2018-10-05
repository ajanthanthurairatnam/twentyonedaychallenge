namespace Challenge21.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDBCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChallengeStatus",
                c => new
                    {
                        ChallengeStatusID = c.Int(nullable: false, identity: true),
                        ChallengeStatusDescription = c.String(),
                    })
                .PrimaryKey(t => t.ChallengeStatusID);
            
            CreateTable(
                "dbo.UserChallenges",
                c => new
                    {
                        UserChallengeID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        UserChallengeDescription = c.String(),
                        UserChallengeEstimatedStartDate = c.DateTime(nullable: false),
                        UserChallengeEstimatedEndDate = c.DateTime(nullable: false),
                        ChallengeTypeID = c.Int(),
                        UserChallengeActualStartDate = c.DateTime(nullable: false),
                        UserChallengeActualEndDate = c.DateTime(nullable: false),
                        UserChallengeCompletionNotes = c.String(),
                        ChallengeStatusID = c.Int(),
                    })
                .PrimaryKey(t => t.UserChallengeID)
                .ForeignKey("dbo.ChallengeStatus", t => t.ChallengeStatusID)
                .ForeignKey("dbo.ChallengeTypes", t => t.ChallengeTypeID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.ChallengeTypeID)
                .Index(t => t.ChallengeStatusID);
            
            CreateTable(
                "dbo.ChallengeTypes",
                c => new
                    {
                        ChallengeTypeID = c.Int(nullable: false, identity: true),
                        ChallengeTypeDescription = c.String(),
                        ChallengeTypeNotes = c.String(),
                    })
                .PrimaryKey(t => t.ChallengeTypeID);
            
            CreateTable(
                "dbo.UserChallengeItems",
                c => new
                    {
                        UserChallengeItemID = c.Int(nullable: false, identity: true),
                        UserChallengeID = c.Int(nullable: false),
                        UserChallengeItemDescription = c.String(),
                        ChallengeTypeID = c.Int(),
                        UserChallengeItemEstimatedStartDate = c.DateTime(),
                        UserChallengeItemEstimatedEndDate = c.DateTime(),
                        UserChallengeItemActualStartDate = c.DateTime(),
                        UserChallengeItemActualEndDate = c.DateTime(),
                        UserChallengeItemCompletionNotes = c.String(),
                        ChallengeStatusID = c.Int(),
                        ChallengeStatus_ChallengeStatusID = c.Int(),
                    })
                .PrimaryKey(t => t.UserChallengeItemID)
                .ForeignKey("dbo.ChallengeStatus", t => t.ChallengeStatusID)
                .ForeignKey("dbo.ChallengeStatus", t => t.ChallengeTypeID)
                .ForeignKey("dbo.UserChallenges", t => t.UserChallengeID, cascadeDelete: true)
                .ForeignKey("dbo.ChallengeTypes", t => t.ChallengeTypeID)
                .ForeignKey("dbo.ChallengeStatus", t => t.ChallengeStatus_ChallengeStatusID)
                .Index(t => t.UserChallengeID)
                .Index(t => t.ChallengeTypeID)
                .Index(t => t.ChallengeStatusID)
                .Index(t => t.ChallengeStatus_ChallengeStatusID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserChallengeItems", "ChallengeStatus_ChallengeStatusID", "dbo.ChallengeStatus");
            DropForeignKey("dbo.UserChallenges", "UserID", "dbo.Users");
            DropForeignKey("dbo.UserChallenges", "ChallengeTypeID", "dbo.ChallengeTypes");
            DropForeignKey("dbo.UserChallengeItems", "ChallengeTypeID", "dbo.ChallengeTypes");
            DropForeignKey("dbo.UserChallengeItems", "UserChallengeID", "dbo.UserChallenges");
            DropForeignKey("dbo.UserChallengeItems", "ChallengeTypeID", "dbo.ChallengeStatus");
            DropForeignKey("dbo.UserChallengeItems", "ChallengeStatusID", "dbo.ChallengeStatus");
            DropForeignKey("dbo.UserChallenges", "ChallengeStatusID", "dbo.ChallengeStatus");
            DropIndex("dbo.UserChallengeItems", new[] { "ChallengeStatus_ChallengeStatusID" });
            DropIndex("dbo.UserChallengeItems", new[] { "ChallengeStatusID" });
            DropIndex("dbo.UserChallengeItems", new[] { "ChallengeTypeID" });
            DropIndex("dbo.UserChallengeItems", new[] { "UserChallengeID" });
            DropIndex("dbo.UserChallenges", new[] { "ChallengeStatusID" });
            DropIndex("dbo.UserChallenges", new[] { "ChallengeTypeID" });
            DropIndex("dbo.UserChallenges", new[] { "UserID" });
            DropTable("dbo.Users");
            DropTable("dbo.UserChallengeItems");
            DropTable("dbo.ChallengeTypes");
            DropTable("dbo.UserChallenges");
            DropTable("dbo.ChallengeStatus");
        }
    }
}
