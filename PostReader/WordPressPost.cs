using System;
using System.Collections.Generic;
using System.Text;

namespace PostReader {
    class WordPressPost {
        // https://developer.wordpress.org/reference/classes/wp_post/
        // All Values can be found here
        public int ID {
            get; set;
        }
        public int post_author {
            get; set;
        }

        public string post_date {
            get; set;
        }

        public string post_date_gmt {
            get; set;
        }

        public string post_content {
            get; set;
        }

        public string post_title {
            get; set;
        }

        public string post_excerpt {
            get; set;
        }

        public string post_status {
            get; set;
        }

        public string comment_status {
            get; set;
        }

        public string ping_status {
            get; set;
        }

        //Not sure if this should be included

        public string to_ping {
            get; set;
        }

        public string pinged {
            get; set;
        }

        public string post_modified {
            get; set;
        }

        public string post_modified_gmt {
            get; set;
        }

        public string post_content_filtered {
            get; set;
        }

        public int post_parent {
            get; set;
        }

        public string guid {
            get; set;
        }

        public int menu_order {
            get; set;
        }

        public string post_type {
            get; set;
        }

        public string post_mime_type {
            get; set;
        }

        public string comment_count {
            get; set;
        }

        public string ToString() {
            return JSON_String;
        }
        
        public string JSON_String {
            get; set;
        }

    }
}
