﻿using FluentMigrator;
using Nop.Core.Domain.News;

namespace Nop.Data.Migrations.News
{
    [Migration(637097798362530772)]
    public class AddNewsCommentNewsItemFK : AutoReversingMigration
    {
        #region Methods

        public override void Up()
        {
            Create.ForeignKey().FromTable(nameof(NewsComment))
                .ForeignColumn(nameof(NewsComment.NewsItemId))
                .ToTable(nameof(NewsItem))
                .PrimaryColumn(nameof(NewsItem.Id));
        }

        #endregion
    }
}