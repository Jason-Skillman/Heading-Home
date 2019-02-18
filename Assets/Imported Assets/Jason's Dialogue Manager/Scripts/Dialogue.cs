using UnityEngine;

namespace DialogueManager {

    [System.Serializable]
    public class Dialogue {
        public string name;

		public Sprite spriteIcon;

        [TextArea(3, 10)]
        public string[] sentences;
    }

	[System.Serializable]
	public class DialogueSingle {
		public string name;
		public string sentence;
	}

}