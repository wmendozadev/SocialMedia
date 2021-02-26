﻿using Microsoft.EntityFrameworkCore;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using SocialMedia.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Repositories
{
    public  class PostRepository : IPostRepository
    {

        private readonly SocialMediaContext _context;
        public PostRepository(SocialMediaContext contex)
        {
            _context = contex;
        }


        public async Task<IEnumerable<Post>> GetPosts()
        {
            var posts =await  _context.Posts.ToListAsync();
            return posts;
        }
          
    }
} 
