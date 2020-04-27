using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Twitch_to_Facebook
{
    class Twtfb
    {
        private Dictionary<string, string> settings;
        public void Load()
        {
            if (!File.Exists("settings.bin"))
            {
                settings = new Dictionary<string, string>();
            }
            else
            {

                IFormatter formatter = new BinaryFormatter();

                Stream stream = new FileStream("settings.bin", FileMode.Open, FileAccess.Read, FileShare.None);
                settings = (Dictionary<string, string>)formatter.Deserialize(stream);
                stream.Close();
            }
        }

        public void ClearStreamlink()
        {
            if (settings.ContainsKey("streamlink"))
            {
                settings.Remove("streamlink");
            }
        }

        public void SetFacebook(string key)
        {
            settings["facebook"] = key;
        }

        public void SetTwitch(string key)
        {
            settings["twitch"] = key;
        }

        public string Get(string key)
        {
            if (settings.ContainsKey(key))
            {
                return settings[key];
            }

            return "";
        }

        public bool TestStreamlink(string path)
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = path,
                    Arguments = "--version",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();

                if (line.Substring(0, 12) != "streamlink 1")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        public bool TestFfmpeg(string path)
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = path,
                    Arguments = "-version",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();

                if (line.Substring(0, 9) != "ffmpeg ve")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
        public bool SetFfmpeg(string path)
        {
            if (TestFfmpeg(path))
            {
                settings["ffmpeg"] = path;
                return true;
            }
            return false;
        }


        public bool SetStreamlink(string path)
        {
            if (TestStreamlink(path))
            {
                settings["streamlink"] = path;
                return true;        
            }
            return false;
        }

        public bool SetSamplingrate(string samplingrate)
        {
            settings["samplingrate"] = samplingrate;
            return true;
        }

        public void ClearFfmpeg()
        {
            if (settings.ContainsKey("ffmpeg"))
            {
                settings.Remove("ffmpeg");
            }
        }

        public int Start()
        {
            this.Save();
            if (settings.ContainsKey("ffmpeg") == false)
            {
                return 0;
            }

            if (TestFfmpeg(settings["ffmpeg"]) == false)
            {
                return 1;
            }

            if (settings.ContainsKey("streamlink") == false)
            {
                return 2;
            }

            if (TestStreamlink(settings["streamlink"]) == false)
            {
                return 3;
            }

            if (settings.ContainsKey("facebook") == false)
            {
                return 4;
            }

            if (settings.ContainsKey("twitch") == false)
            {
                return 5;
            }

            if (settings.ContainsKey("samplingrate") == false)
            {
                return 6;
            }


                string arg = "\"" + settings["streamlink"] +"\"" + " https://www.twitch.tv/" + settings["twitch"] + " best -O | \""+settings["ffmpeg"] + "\" -i - -deinterlace -vcodec copy -pix_fmt yuv420p -preset medium -r 30 -g 60 -b:v 2500k -ar "+settings["samplingrate"]+" -bufsize 512k -f flv \"rtmps://live-api-s.facebook.com:443/rtmp/"+settings["facebook"]+"\"";
            StreamWriter writer = new StreamWriter("run.bat");
            writer.WriteLine(arg);
            writer.Close();            
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "run.bat",
                    UseShellExecute = true,
                    RedirectStandardOutput = false,
                    RedirectStandardError = false,
                    CreateNoWindow = false
                }
            };

            proc.Start();
            if (proc != null && !proc.HasExited)
                proc.WaitForExit();

            return 6;
        }

        private void Proc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            if (settings != null)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("settings.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, settings);
                stream.Close();
            }
        }
    }
}
