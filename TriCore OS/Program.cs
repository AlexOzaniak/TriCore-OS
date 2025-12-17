using TriCore_OS.Login;

FileEngine engine = new FileEngine();
LoginDetailsExtraction extraction = new LoginDetailsExtraction();
engine.EngineStart(extraction);