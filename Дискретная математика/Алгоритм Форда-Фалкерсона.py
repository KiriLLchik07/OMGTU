def bfs(graph, s, t, parent):
    visited = [False] * len(graph)
    queue = []
    queue.append(s)
    visited[s] = True

    while queue:
        u = queue.pop(0)

        for v in range(len(graph)):
            if not visited[v] and graph[u][v] > 0:
                queue.append(v)
                visited[v] = True
                parent[v] = u

    return visited[t]

def ford_fulkerson(graph, source, sink):
    parent = [-1] * len(graph)
    max_flow = 0

    while bfs(graph, source, sink, parent):
        path_flow = float('inf')
        s = sink

        while s != source:
            path_flow = min(path_flow, graph[parent[s]][s])
            s = parent[s]

        max_flow += path_flow
        v = sink

        while v != source:
            u = parent[v]
            graph[u][v] -= path_flow
            graph[v][u] += path_flow
            v = parent[v]

    return max_flow

# Пример 
graph_matrix = [
    [0, 20, 30, 10, 0],
    [20, 0, 40, 0, 30],
    [30, 40, 0, 10, 20],
    [10, 0, 10, 0, 20],
    [0, 30, 20, 20, 0]
]

source = 0
sink = 4
print("Максимальный поток:", ford_fulkerson(graph_matrix, source, sink))


