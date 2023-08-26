﻿namespace ABC_University.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        courseID = c.Int(nullable: false, identity: true),
                        courseName = c.String(),
                        isAvailable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.courseID);
            
            CreateTable(
                "dbo.rooms",
                c => new
                    {
                        roomID = c.Int(nullable: false, identity: true),
                        roomName = c.String(),
                        roomSize = c.Int(nullable: false),
                        isAvailable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.roomID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        studentID = c.Int(nullable: false, identity: true),
                        studentName = c.String(),
                        studentNumber = c.String(),
                    })
                .PrimaryKey(t => t.studentID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        teacherID = c.Int(nullable: false, identity: true),
                        teacherName = c.String(),
                        teacherNumber = c.String(),
                    })
                .PrimaryKey(t => t.teacherID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.rooms");
            DropTable("dbo.Courses");
        }
    }
}
