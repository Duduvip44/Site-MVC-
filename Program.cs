Console.WriteLine("Bem Vindo a Plataforma Online de Cursos");




var professorService = new ProfessorService();
var coordenadorService = new CoordenadorService();
var materiaService = new MateriaService();
var extensaoService = new ExtesnsaoService();

Console.WriteLine("Cadastro Professor (2 professores)");
professorService.IniciarCadastro();
professorService.IniciarCadastro();

Console.WriteLine("Cadastro Coordenador (2 coordenadores)");
coordenadorService.IniciarCadastro();
coordenadorService.IniciarCadastro();

Console.WriteLine("Cadastro Materia (2 materias)");
materiaService.CriarMateria(professorService.ObterTodos());
materiaService.CriarMateria(professorService.ObterTodos());

static void MateriaCriada(object source, EventArgs e)
{
    MateriaService materia = (MateriaService)source;
    Console.WriteLine("A matéria foi criada com sucesso!.");
    Console.ReadLine();
}

materiaService.CriouMateria += new MateriaService.MateriaCriadaEventHandler(MateriaCriada);
materiaService.CriouMateria += professorService.OnCriouMateria;
materiaService.CriouMateria += coordenadorService.OnCriouMateria;

Console.WriteLine("Cadastro Extensao (2 extensoes)");
extensaoService.CriarExtensao(professorService.ObterTodos());
extensaoService.CriarExtensao(professorService.ObterTodos());

