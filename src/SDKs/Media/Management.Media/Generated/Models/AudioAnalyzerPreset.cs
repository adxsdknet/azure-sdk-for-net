// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Audio Analyzer preset applies a pre-defined set of AI-based
    /// analysis operations, including speech transcription. Currently, the
    /// preset supports processing of content with a single audio track.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.AudioAnalyzerPreset")]
    public partial class AudioAnalyzerPreset : Preset
    {
        /// <summary>
        /// Initializes a new instance of the AudioAnalyzerPreset class.
        /// </summary>
        public AudioAnalyzerPreset()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AudioAnalyzerPreset class.
        /// </summary>
        /// <param name="audioLanguage">The language for the audio payload in
        /// the input using the BCP-47 format of 'language tag-region' (e.g:
        /// 'en-US').  The list of supported languages are English ('en-US' and
        /// 'en-GB'), Spanish ('es-ES' and 'es-MX'), French ('fr-FR'), Italian
        /// ('it-IT'), Japanese ('ja-JP'), Portuguese ('pt-BR'), Chinese
        /// ('zh-CN'), German ('de-DE'), Arabic ('ar-EG'), Russian ('ru-RU'),
        /// Hindi ('hi-IN'), and Korean ('ko-KR'). If you know the language of
        /// your content, it is recommended that you specify it. If the
        /// language isn't specified or set to null, automatic language
        /// detection will choose the first language detected and process with
        /// the selected language for the duration of the file. This language
        /// detection feature currently supports English, Chinese, French,
        /// German, Italian, Japanese, Spanish, Russian, and Portuguese. It
        /// does not currently support dynamically switching between languages
        /// after the first language is detected. The automatic detection works
        /// best with audio recordings with clearly discernable speech. If
        /// automatic detection fails to find the language, transcription would
        /// fallback to 'en-US'."</param>
        public AudioAnalyzerPreset(string audioLanguage = default(string))
        {
            AudioLanguage = audioLanguage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the language for the audio payload in the input using
        /// the BCP-47 format of 'language tag-region' (e.g: 'en-US').  The
        /// list of supported languages are English ('en-US' and 'en-GB'),
        /// Spanish ('es-ES' and 'es-MX'), French ('fr-FR'), Italian ('it-IT'),
        /// Japanese ('ja-JP'), Portuguese ('pt-BR'), Chinese ('zh-CN'), German
        /// ('de-DE'), Arabic ('ar-EG'), Russian ('ru-RU'), Hindi ('hi-IN'),
        /// and Korean ('ko-KR'). If you know the language of your content, it
        /// is recommended that you specify it. If the language isn't specified
        /// or set to null, automatic language detection will choose the first
        /// language detected and process with the selected language for the
        /// duration of the file. This language detection feature currently
        /// supports English, Chinese, French, German, Italian, Japanese,
        /// Spanish, Russian, and Portuguese. It does not currently support
        /// dynamically switching between languages after the first language is
        /// detected. The automatic detection works best with audio recordings
        /// with clearly discernable speech. If automatic detection fails to
        /// find the language, transcription would fallback to 'en-US'."
        /// </summary>
        [JsonProperty(PropertyName = "audioLanguage")]
        public string AudioLanguage { get; set; }

    }
}
