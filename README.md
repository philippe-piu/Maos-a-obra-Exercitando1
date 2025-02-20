# Mãos à Obra 1

<h2>📌 Objetivo</h2>
<p>Criar um jogo simples onde o jogador controla um objeto que pode se mover e rotacionar, desviando de obstáculos gerados automaticamente.</p>

<h2>🛠️ Configuração Inicial</h2>
<h3>1️⃣ Criando o Projeto</h3>
<ol>
    <li><strong>Crie um novo projeto no Unity</strong> usando a template <strong>3D</strong>.</li>
    <li><strong>Crie um novo objeto vazio na cena</strong> e nomeie-o como <code>GameManager</code>.</li>
    <li><strong>Crie três scripts</strong> na pasta <code>Scripts</code>:</li>
    <ul>
        <li><code>Player.cs</code> (Movimentação do jogador)</li>
        <li><code>Prefab.cs</code> (Gerador de obstáculos)</li>
        <li><code>Parede.cs</code> (Movimentação dos obstáculos)</li>
    </ul>
</ol>

<h2>🎮 Configuração do Player</h2>
<ol>
    <li><strong>Crie um Cubo</strong> (<code>GameObject > 3D Object > Cube</code>) e nomeie-o <code>Player</code>.</li>
    <li><strong>Adicione um Rigidbody</strong> ao <code>Player</code>.</li>
    <li><strong>Adicione o script <code>Player.cs</code></strong> ao <code>Player</code>.</li>
    <li>Configure os valores de <strong>velocidade</strong> e <strong>rotação</strong> no <strong>Inspector</strong>.</li>
</ol>

<h2>🔄 Configuração do Spawner de Obstáculos</h2>
<ol>
    <li><strong>Crie um GameObject vazio</strong> e nomeie-o <code>Spawner</code>.</li>
    <li><strong>Adicione o script <code>Prefab.cs</code></strong> ao <code>Spawner</code>.</li>
    <li>No <strong>Inspector</strong>, adicione diferentes <strong>obstáculos (Cubos, Esferas, etc.)</strong> à lista <code>Ob</code>.</li>
    <li>Defina o tempo de spawn no <strong>Inspector</strong> (ex: <code>spawnerObTempo = 3f</code>).</li>
</ol>

<h2>🧱 Configuração dos Obstáculos</h2>
<ol>
    <li><strong>Crie um Cubo</strong> (<code>GameObject > 3D Object > Cube</code>) e nomeie-o <code>Parede</code>.</li>
    <li><strong>Adicione o script <code>Parede.cs</code></strong> ao <code>Parede</code>.</li>
    <li>No <strong>Inspector</strong>, defina um valor para <code>obVelocidade</code> (ex: <code>5f</code>).</li>
    <li><strong>Arraste esse objeto para a pasta <code>Prefabs</code> e transforme-o em um Prefab</strong>.</li>
</ol>

<h2>✅ Testando e Ajustando</h2>
<ul>
    <li>Pressione <strong>Play</strong> e teste a movimentação do player e a geração dos obstáculos.</li>
    <li>Ajuste os valores de velocidade e tempo de spawn se necessário.</li>
</ul>