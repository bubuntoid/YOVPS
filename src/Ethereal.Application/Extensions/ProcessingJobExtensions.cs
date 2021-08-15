﻿using System.IO;
using Ethereal.Domain.Entities;

namespace Ethereal.Application.Extensions
{
    public static class ProcessingJobExtensions
    {
        public static string GetLocalVideoPath(this ProcessingJob job)
        {
            return Path.Combine(job.LocalPath, EtherealConstants.OriginalVideoFileName);
        }

        public static string GetLocalThumbnailsDirectoryPath(this ProcessingJob job)
        {
            return Path.Combine(job.LocalPath, EtherealConstants.ThumbnailsDirectoryName);
        }

        public static string GetArchivePath(this ProcessingJob job)
        {
            return Path.Combine(job.LocalPath, job.VideoTitle.RemoveIllegalCharacters() + ".zip");
        }

        public static string GetChapterLocalFilePath(this ProcessingJob job, VideoChapter chapter)
        {
            return Path.Combine(job.LocalPath, $"{chapter.Name}.mp4");
        }
    }
}